#include "DirectXCore.h"



DirectXCore::DirectXCore()
	: D3DDevice(nullptr)
	, IsUAVLoadSupport_R11G11B10_FLOAT(false)
	, IsUAVLoadSupport_R16G16B16A16_FLOAT(false)
{
}

bool DirectXCore::Initialize_MemberFunction()
{
	ComPtr<ID3D12Device> pDevice;

#if _DEBUG
	Microsoft::WRL::ComPtr<ID3D12Debug> debugInterface;
	if (SUCCEEDED(D3D12GetDebugInterface(IID_PPV_ARGS(&debugInterface)) >= 0))
		debugInterface->EnableDebugLayer();
#endif

	//EnableExperimentalShaderModels();

	ComPtr<IDXGIFactory4> dxgiFactory;
	if (FAILED(CreateDXGIFactory2(0, IID_PPV_ARGS(&dxgiFactory)) < 0))
		return false;

	ComPtr<IDXGIAdapter1> pAdapter;

	static const bool bUseWarpDriver = false;

	if (!bUseWarpDriver)
	{
		SIZE_T MaxSize = 0;

		for (uint32_t Idx = 0; DXGI_ERROR_NOT_FOUND != dxgiFactory->EnumAdapters1(Idx, &pAdapter); ++Idx)
		{
			DXGI_ADAPTER_DESC1 desc;
			pAdapter->GetDesc1(&desc);
			if (desc.Flags & DXGI_ADAPTER_FLAG_SOFTWARE)
				continue;

			if (desc.DedicatedVideoMemory > MaxSize
				&& SUCCEEDED(D3D12CreateDevice(pAdapter.Get(), D3D_FEATURE_LEVEL_11_0, IID_PPV_ARGS(&pDevice))))
			{
				pAdapter->GetDesc1(&desc);
				MaxSize = desc.DedicatedVideoMemory;
			}
		}

		if (MaxSize > 0)
			D3DDevice = pDevice.Detach();
	}

	if (D3DDevice == nullptr)
	{
		if (FAILED(dxgiFactory->EnumWarpAdapter(IID_PPV_ARGS(&pAdapter))))
			return false;
		if (FAILED(D3D12CreateDevice(pAdapter.Get(), D3D_FEATURE_LEVEL_11_0, IID_PPV_ARGS(&pDevice))))
			return false;
		D3DDevice = pDevice.Detach();
	}

	D3D12_FEATURE_DATA_D3D12_OPTIONS FeatureData = {};
	if (SUCCEEDED(D3DDevice->CheckFeatureSupport(D3D12_FEATURE_D3D12_OPTIONS, &FeatureData, sizeof(FeatureData))))
	{
		if (FeatureData.TypedUAVLoadAdditionalFormats)
		{
			D3D12_FEATURE_DATA_FORMAT_SUPPORT Support =
			{
				DXGI_FORMAT_R11G11B10_FLOAT, D3D12_FORMAT_SUPPORT1_NONE, D3D12_FORMAT_SUPPORT2_NONE
			};

			if (SUCCEEDED(D3DDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_SUPPORT, &Support, sizeof(Support))) &&
				(Support.Support2 & D3D12_FORMAT_SUPPORT2_UAV_TYPED_LOAD) != 0)
			{
				IsUAVLoadSupport_R11G11B10_FLOAT = true;
			}

			Support.Format = DXGI_FORMAT_R16G16B16A16_FLOAT;

			if (SUCCEEDED(D3DDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_SUPPORT, &Support, sizeof(Support))) &&
				(Support.Support2 & D3D12_FORMAT_SUPPORT2_UAV_TYPED_LOAD) != 0)
			{
				IsUAVLoadSupport_R16G16B16A16_FLOAT = true;
			}
		}
	}

}

DirectXCore * DirectXCore::GetInstance()
{
	static DirectXCore instance;
	return &instance;
}

bool DirectXCore::Initialize()
{
	return GetInstance()->Initialize_MemberFunction();
}

