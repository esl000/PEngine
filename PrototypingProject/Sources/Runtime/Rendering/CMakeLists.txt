cmake_minimum_required(VERSION 3.1)

project(Rendering)

source_group(Private FILES Private/Graphics.cpp
)

source_group(Private\\DirectX FILES Private/DirectX/D3D12Core.cpp
Private/DirectX/d3dUtil.cpp
Private/DirectX/DirectXHeader.cpp
)

source_group(Public FILES Public/Graphics.h
)

source_group(Public\\DirectX FILES Public/DirectX/D3D12Core.h
Public/DirectX/d3dUtil.h
Public/DirectX/d3dx12.h
Public/DirectX/DirectXHeader.h
)

add_library(Rendering E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Rendering.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/Graphics.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/D3D12Core.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/d3dUtil.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/DirectXHeader.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/Graphics.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/D3D12Core.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/d3dUtil.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/d3dx12.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/DirectXHeader.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
)

target_link_libraries(Rendering Core
)

add_definitions(-D_EDITABLE_PROJECT)
add_definitions(-D_UNICODE)
