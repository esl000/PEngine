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

	//����̽� ��ü ����
	void CreateDevice();
	//�潺 ����
	void CreateFence();
	//������ �� ����
	void GetDescripterSize();
	//���� ���ø� ���� Ȯ��
	void CheckingSupport4XMSAA();
	//Ŀ��Ʈ ť, �Ҵ���(allocator), ����Ʈ ����
	void CreateCommandObjects();
	//���� ü�� ����
	void CreateSwapChain();
	//������ �� ����
	void CreateDescriptorHeap();
	//���� Ÿ�� �� ����
	void CreateRenderTargetView();
	//���� ���ٽ� �� ����
	void CreateDepthStencilView();
	//����Ʈ ����
	void SetViewport();
	//Ŭ���� ���� ���� 
	void SetScissorRect();

protected:
	HWND _targetHwnd; // �ӽ� �� ���߿��� ����â �ʱ�ȭ �ؾ���

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

	//�����(����Ÿ�� ��) ������ ũ��
	UINT _renderTargetViewDescripterSize;
	//����, ���ٽ� ���� ������ ũ��
	UINT _depthStencilViewDescripterSize;
	//��� ���� ������ ũ��
	UINT _constantBufferViewDescripterSize;
	//���� ���ø� ���� ����
	UINT _4XMSAAQualityLevels;
	UINT _swapChainBufferCount;
	DXGI_FORMAT _backBufferFormat;

	BOOL _is4XMSAAEnabled;
};

