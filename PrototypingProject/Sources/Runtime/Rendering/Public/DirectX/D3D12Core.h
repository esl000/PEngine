#pragma once

#include <PEngineMacros.h>
#include <DirectXHeader.h>

#define g_D3D12Core D3D12Core::GetInstance()

#define SwapChainBufferCount 3

class D3D12Core
{
	SINGLETONE(D3D12Core)

public:

	void InitializeCore();
	void CreateDevice();
	void SetupRenderer();

	void FlushCommandQueue();

	void Draw();

public:
	PROPERTY_GET(bool, b4xMsaaState)
	PROPERTY_GET(UINT, i4xMsaaQuality)
	PROPERTY_GET(UINT64, CurrentFence)

	PROPERTY_GET(Microsoft::WRL::ComPtr<ID3D12Device>, Device)
	PROPERTY_GET(Microsoft::WRL::ComPtr<IDXGIAdapter1>, Adapter)
	PROPERTY_GET(Microsoft::WRL::ComPtr<IDXGIFactory4>, DxgiFactory)
	PROPERTY_GET(Microsoft::WRL::ComPtr<ID3D12Fence>, Fence)
	PROPERTY_GET(Microsoft::WRL::ComPtr<IDXGISwapChain>, SwapChain)

	PROPERTY_GET(Microsoft::WRL::ComPtr<ID3D12CommandQueue>, CommandQueue)
	PROPERTY_GET(Microsoft::WRL::ComPtr<ID3D12CommandAllocator>, DirectCmdListAlloc)
	PROPERTY_GET(Microsoft::WRL::ComPtr<ID3D12GraphicsCommandList>, CommandList)


	Microsoft::WRL::ComPtr<ID3D12Resource> SwapChainBuffer[SwapChainBufferCount];
	Microsoft::WRL::ComPtr<ID3D12Resource> DepthStencilBuffer;

	Microsoft::WRL::ComPtr<ID3D12DescriptorHeap> RtvHeap;
	Microsoft::WRL::ComPtr<ID3D12DescriptorHeap> DsvHeap;

	D3D12_VIEWPORT ScreenViewport;
	D3D12_RECT ScissorRect;

	UINT RtvDescriptorSize = 0;
	UINT DsvDescriptorSize = 0;
	UINT CbvSrvUavDescriptorSize = 0;

	int CurrBackBuffer = 0;

	// Derived class should set these in derived constructor to customize starting values.
	std::wstring MainWndCaption = L"d3d App";
	D3D_DRIVER_TYPE d3dDriverType = D3D_DRIVER_TYPE_HARDWARE;
	DXGI_FORMAT BackBufferFormat = DXGI_FORMAT_R8G8B8A8_UNORM;
	DXGI_FORMAT DepthStencilFormat = DXGI_FORMAT_D24_UNORM_S8_UINT;
	int ClientWidth = 800;
	int ClientHeight = 600;


	Microsoft::WRL::ComPtr<ID3D12RootSignature> RootSignature = nullptr;
	Microsoft::WRL::ComPtr<ID3D12DescriptorHeap> mCbvHeap = nullptr;

	Microsoft::WRL::ComPtr<ID3D12DescriptorHeap> mSrvDescriptorHeap = nullptr;

	std::unordered_map<std::string, Microsoft::WRL::ComPtr<ID3DBlob>> Shaders;
	std::unordered_map<std::string, Microsoft::WRL::ComPtr<ID3D12PipelineState>> PSOs;

	std::vector<D3D12_INPUT_ELEMENT_DESC> mInputLayout;


	UINT mPassCbvOffset = 0;

	bool mIsWireframe = false;

	float mRadius = 15.0f;

	POINT mLastMousePos;
};
