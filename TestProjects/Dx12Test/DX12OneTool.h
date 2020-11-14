#pragma once

#include "D3DUtil.h"

#define SwapChainBufferCount 3

using Microsoft::WRL::ComPtr;

class DX12OneTool
{
public:
	DX12OneTool(HWND hWnd);
	~DX12OneTool();

	RECT GetRect();

	//디바이스 객체 생성
	void CreateDevice();
	//펜스 생성
	void CreateFence();
	//서술자 힙 생성
	void GetDescripterSize();
	//다중 샘플링 지원 확인
	void CheckingSupport4XMSAA();
	//커맨트 큐, 할당자(allocator), 리스트 생성
	void CreateCommandObjects();
	//스왑 체인 생성
	void CreateSwapChain();
	//서술자 힙 생성
	void CreateDescriptorHeap();
	//렌더 타겟 뷰 생성
	void CreateRenderTargetView();
	//깊이 스텐실 뷰 생성
	void CreateDepthStencilView();
	//뷰포트 설정
	void SetViewport();
	//클리핑 가위 설정 
	void SetScissorRect();

protected:
	HWND _targetHwnd; // 임시 값 나중에는 여러창 초기화 해야함

	ComPtr<IDXGIFactory4> _dxgiFactory;
	ComPtr<ID3D12Device> _d3d12Device;
	ComPtr<ID3D12Fence> _fence;
	ComPtr<ID3D12CommandQueue> _commandQueue;
	ComPtr<ID3D12CommandAllocator> _commandAllocator;
	ComPtr<ID3D12GraphicsCommandList> _commandList;
	ComPtr<IDXGISwapChain> _swapChain;

	ComPtr<ID3D12DescriptorHeap> _rtvHeap;
	ComPtr<ID3D12DescriptorHeap> _dsvHeap;

	ComPtr<ID3D12Resource> _swapChainBuffers[SwapChainBufferCount];
	ComPtr<ID3D12Resource> _depthStencilBuffer;

	D3D12_VIEWPORT _viewPort;

	//백버퍼(렌더타겟 뷰) 서술자 크기
	UINT _renderTargetViewDescripterSize;
	//깊이, 스텐실 버퍼 서술자 크기
	UINT _depthStencilViewDescripterSize;
	//상수 버퍼 서술자 크기
	UINT _constantBufferViewDescripterSize;
	//다중 샘플링 지원 레벨
	UINT _4XMSAAQualityLevels;
	UINT _swapChainBufferCount;
	DXGI_FORMAT _backBufferFormat;

	BOOL _is4XMSAAEnabled;
};

