#include "DX12OneTool.h"

DX12OneTool::DX12OneTool(HWND hWnd)
	: _targetHwnd(hWnd)
	, _backBufferFormat(DXGI_FORMAT_R8G8B8A8_UNORM)
	, _swapChainBufferCount(SwapChainBufferCount)
	, _is4XMSAAEnabled(0)
{
	CreateDevice();
	CreateFence();
	GetDescripterSize();
	CheckingSupport4XMSAA();
	CreateCommandObjects();
	CreateSwapChain();
	CreateDescriptorHeap();
	CreateRenderTargetView();
	CreateDepthStencilView();
	SetViewport();
}


DX12OneTool::~DX12OneTool()
{
}

RECT DX12OneTool::GetRect()
{
	RECT rc;
	GetClientRect(_targetHwnd, &rc);
	return rc;
}

void DX12OneTool::CreateDevice()
{
#if defined(DEBUG) || defined(_DEBUG)
	{
		ComPtr<ID3D12Debug> debugController;
		ThrowIfFailed(D3D12GetDebugInterface(IID_PPV_ARGS(&debugController)));
		debugController->EnableDebugLayer();
	}
#endif
	
	//dxgi factory 생성
	//dxgifactory4 -> window10

	DWORD dxgiFactoryFlags = 0;
#ifdef _DEBUG
	dxgiFactoryFlags = DXGI_CREATE_FACTORY_DEBUG;
#endif

	ThrowIfFailed(CreateDXGIFactory2(dxgiFactoryFlags, IID_PPV_ARGS(&_dxgiFactory)));

	//dx12 device 객체 생성
	//dxgi 타겟 하드웨어 존재 x -> fail
	HRESULT hardwareResult = D3D12CreateDevice(
		nullptr,
		D3D_FEATURE_LEVEL_12_1,
		IID_PPV_ARGS(&_d3d12Device));

	if (FAILED(hardwareResult))
	{
		//software dxgiadapter 생성
		ComPtr<IDXGIAdapter> warpAdapter;
		ThrowIfFailed(_dxgiFactory->EnumWarpAdapter(IID_PPV_ARGS(&warpAdapter)));

		ThrowIfFailed(D3D12CreateDevice(
			warpAdapter.Get(),
			D3D_FEATURE_LEVEL_12_1,
			IID_PPV_ARGS(&_d3d12Device)
		));
	}
}

void DX12OneTool::CreateFence()
{
	//펜스 생성
	ThrowIfFailed(_d3d12Device->CreateFence(0, D3D12_FENCE_FLAG_NONE, IID_PPV_ARGS(&_fence)));
}

void DX12OneTool::GetDescripterSize()
{
	//gpu 장치에 할당되있는 서술자 사이즈 가져오기
	_renderTargetViewDescripterSize = _d3d12Device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_RTV);
	_depthStencilViewDescripterSize = _d3d12Device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_DSV);
	_constantBufferViewDescripterSize = _d3d12Device->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV);
}

void DX12OneTool::CheckingSupport4XMSAA()
{
	//다중 샘플링 설정 구조체
	D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS msQualityLevels;
	msQualityLevels.Format = _backBufferFormat; //임의의 텍스쳐 포맷
	msQualityLevels.SampleCount = 4; //4xmsaa
	msQualityLevels.Flags = D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE;
	msQualityLevels.NumQualityLevels = 0;

	//백 버퍼 다중 샘플링 지원 여부 확인
	ThrowIfFailed(_d3d12Device->CheckFeatureSupport(
			D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS,
			&msQualityLevels,
			sizeof(msQualityLevels)
		));

	_4XMSAAQualityLevels = msQualityLevels.NumQualityLevels;

	assert(_4XMSAAQualityLevels > 0 && "Not Supported 4XMSAA in gpu");
}

void DX12OneTool::CreateCommandObjects()
{
	//커맨드 큐 서술자
	D3D12_COMMAND_QUEUE_DESC queueDecs = {};
	queueDecs.Type = D3D12_COMMAND_LIST_TYPE_DIRECT;
	queueDecs.Flags = D3D12_COMMAND_QUEUE_FLAG_NONE;

	// 커맨드 큐 생성
	ThrowIfFailed(_d3d12Device->CreateCommandQueue(
		&queueDecs,
		IID_PPV_ARGS(&_commandQueue)));

	//커맨드 할당자 생성
	ThrowIfFailed(_d3d12Device->CreateCommandAllocator(
		D3D12_COMMAND_LIST_TYPE_DIRECT,
		IID_PPV_ARGS(&_commandAllocator)));
	
	//커맨드 리스트 생성
	ThrowIfFailed(_d3d12Device->CreateCommandList(
		0,
		D3D12_COMMAND_LIST_TYPE_DIRECT,
		_commandAllocator.Get(),
		nullptr,
		IID_PPV_ARGS(&_commandList)));

	_commandList->Close();
}

void DX12OneTool::CreateSwapChain()
{
	_swapChain.Reset();

	RECT rc = GetRect();

	DXGI_SWAP_CHAIN_DESC swapChainDesc;
	swapChainDesc.BufferDesc.Width = rc.right - rc.left;
	swapChainDesc.BufferDesc.Height = rc.bottom - rc.top;
	swapChainDesc.BufferDesc.RefreshRate.Numerator = 59; // 추후 모니터 주사율에 맞추기
	swapChainDesc.BufferDesc.RefreshRate.Denominator = 1;
	swapChainDesc.BufferDesc.Format = _backBufferFormat;
	swapChainDesc.BufferDesc.ScanlineOrdering = DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED; // 레스터라이저 scanline ordering
	swapChainDesc.BufferDesc.Scaling = DXGI_MODE_SCALING_UNSPECIFIED;
	swapChainDesc.SampleDesc.Count = _is4XMSAAEnabled ? 4 : 1;
	swapChainDesc.SampleDesc.Quality = _is4XMSAAEnabled ? _4XMSAAQualityLevels - 1 : 0;
	swapChainDesc.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
	swapChainDesc.BufferCount = _swapChainBufferCount;
	swapChainDesc.OutputWindow = _targetHwnd;
	swapChainDesc.Windowed = true;
	swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_FLIP_DISCARD;
	swapChainDesc.Flags = DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH;

	ThrowIfFailed(_dxgiFactory->CreateSwapChain(
		_commandQueue.Get(),
		&swapChainDesc,
		_swapChain.GetAddressOf()));

}

void DX12OneTool::CreateDescriptorHeap()
{
	D3D12_DESCRIPTOR_HEAP_DESC rtvHeapDesc;
	rtvHeapDesc.NumDescriptors = _swapChainBufferCount; // 스왑 체인 버퍼수 만큼 갯수 설정
	rtvHeapDesc.Type = D3D12_DESCRIPTOR_HEAP_TYPE_RTV;
	rtvHeapDesc.Flags = D3D12_DESCRIPTOR_HEAP_FLAG_NONE;
	rtvHeapDesc.NodeMask = 0;

	ThrowIfFailed(_d3d12Device->CreateDescriptorHeap(
		&rtvHeapDesc,
		IID_PPV_ARGS(&_rtvHeap)));


	D3D12_DESCRIPTOR_HEAP_DESC dsvHeapDesc;
	dsvHeapDesc.NumDescriptors = 1; // 스왑 체인 버퍼와 관계없이 하나지
	dsvHeapDesc.Type = D3D12_DESCRIPTOR_HEAP_TYPE_DSV;
	dsvHeapDesc.Flags = D3D12_DESCRIPTOR_HEAP_FLAG_NONE;
	dsvHeapDesc.NodeMask = 0;

	ThrowIfFailed(_d3d12Device->CreateDescriptorHeap(
		&dsvHeapDesc,
		IID_PPV_ARGS(&_dsvHeap)));
}

void DX12OneTool::CreateRenderTargetView()
{
	CD3DX12_CPU_DESCRIPTOR_HANDLE rtvHeapHandle(_rtvHeap->GetCPUDescriptorHandleForHeapStart());
	
	for (UINT i = 0; i < _swapChainBufferCount; ++i)
	{
		//스왑 체인 버퍼 가져오기
		ThrowIfFailed(_swapChain->GetBuffer(
			i,
			IID_PPV_ARGS(&_swapChainBuffers[i])));

		//rtv desc 를 힙에 생성하여 넣어준다.
		_d3d12Device->CreateRenderTargetView(
			_swapChainBuffers[i].Get(),
			nullptr,
			rtvHeapHandle);

		rtvHeapHandle.Offset(1, _renderTargetViewDescripterSize);
	}
}

void DX12OneTool::CreateDepthStencilView()
{
	RECT rc = GetRect();

	//깊이 스텐실 버퍼 리소스 서술자 생성
	D3D12_RESOURCE_DESC depthStencilBufferDesc;
	depthStencilBufferDesc.Dimension = D3D12_RESOURCE_DIMENSION_TEXTURE2D;
	depthStencilBufferDesc.Alignment = 0;
	depthStencilBufferDesc.Width = rc.right - rc.left;
	depthStencilBufferDesc.Height = rc.bottom - rc.top;
	depthStencilBufferDesc.DepthOrArraySize = 1;
	depthStencilBufferDesc.MipLevels = 1;
	depthStencilBufferDesc.Format = DXGI_FORMAT_R24G8_TYPELESS;
	depthStencilBufferDesc.SampleDesc.Count = _is4XMSAAEnabled ? 4 : 1;
	depthStencilBufferDesc.SampleDesc.Quality = _is4XMSAAEnabled ? _4XMSAAQualityLevels - 1 : 0;
	depthStencilBufferDesc.Layout = D3D12_TEXTURE_LAYOUT_UNKNOWN;
	depthStencilBufferDesc.Flags = D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL;

	//깊이 스텐실 버퍼 클리어 옵션 설정
	D3D12_CLEAR_VALUE optClear;
	optClear.Format = DXGI_FORMAT_D24_UNORM_S8_UINT;
	optClear.DepthStencil.Depth = 1.0f;
	optClear.DepthStencil.Stencil = 0;

	//깊이 스텐실 버퍼 리소스 만들기
	ThrowIfFailed(_d3d12Device->CreateCommittedResource(
		&CD3DX12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT),
		D3D12_HEAP_FLAG_NONE,
		&depthStencilBufferDesc,
		D3D12_RESOURCE_STATE_COMMON,
		&optClear,
		IID_PPV_ARGS(&_depthStencilBuffer)));

	_d3d12Device->CreateDepthStencilView(
		_depthStencilBuffer.Get(),
		nullptr,
		_dsvHeap->GetCPUDescriptorHandleForHeapStart());

	//리소스 초기상태 -> 쓰기가능 상태로 전이
	_commandList->ResourceBarrier(
		1,
		&CD3DX12_RESOURCE_BARRIER::Transition(
			_depthStencilBuffer.Get(),
			D3D12_RESOURCE_STATE_COMMON,
			D3D12_RESOURCE_STATE_DEPTH_WRITE
		));
}

void DX12OneTool::SetViewport()
{
	RECT rc = GetRect();
	_viewPort.TopLeftX = 0;
	_viewPort.TopLeftY = 0;
	_viewPort.Width = rc.right - rc.left;
	_viewPort.Height = rc.bottom - rc.top;
	_viewPort.MinDepth = 0.f;
	_viewPort.MaxDepth = 1.f;

	_commandList->RSSetViewports(1, &_viewPort);
}

void DX12OneTool::SetScissorRect()
{
}
