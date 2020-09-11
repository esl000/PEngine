#pragma once


#include "WindowHeader.h"

// Link necessary d3d12 libraries.
#pragma comment(lib,"d3dcompiler.lib")
#pragma comment(lib, "D3D12.lib")
#pragma comment(lib, "dxgi.lib")

using namespace Microsoft::WRL;
using namespace std;
using namespace DirectX;


class DirectXCore
{
protected:
	DirectXCore();

	ID3D12Device* D3DDevice;
	bool IsUAVLoadSupport_R11G11B10_FLOAT;
	bool IsUAVLoadSupport_R16G16B16A16_FLOAT;

protected:
	bool Initialize_MemberFunction();
public:
	static DirectXCore* GetInstance();
	static bool Initialize();
};

