cmake_minimum_required(VERSION 3.1)

project(Rendering)

source_group(Private FILES Private/Graphics.cpp
)

source_group(Private\\DirectX FILES Private/DirectX/Camera.cpp
Private/DirectX/d3dApp.cpp
Private/DirectX/d3dUtil.cpp
Private/DirectX/DDSTextureLoader.cpp
Private/DirectX/FrameResource.cpp
Private/DirectX/GameTimer.cpp
Private/DirectX/GeometryGenerator.cpp
Private/DirectX/MathHelper.cpp
Private/DirectX/ShadowMap.cpp
Private/DirectX/ShadowMapApp.cpp
)

source_group(Public FILES Public/Graphics.h
)

source_group(Public\\DirectX FILES Public/DirectX/Camera.h
Public/DirectX/d3dApp.h
Public/DirectX/d3dUtil.h
Public/DirectX/d3dx12.h
Public/DirectX/DDSTextureLoader.h
Public/DirectX/FrameResource.h
Public/DirectX/GameTimer.h
Public/DirectX/GeometryGenerator.h
Public/DirectX/MathHelper.h
Public/DirectX/ShadowMap.h
Public/DirectX/UploadBuffer.h
)

add_library(Rendering E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Rendering.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/Graphics.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/Camera.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/d3dApp.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/d3dUtil.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/DDSTextureLoader.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/FrameResource.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/GameTimer.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/GeometryGenerator.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/MathHelper.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/ShadowMap.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/DirectX/ShadowMapApp.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/Graphics.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/Camera.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/d3dApp.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/d3dUtil.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/d3dx12.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/DDSTextureLoader.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/FrameResource.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/GameTimer.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/GeometryGenerator.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/MathHelper.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/ShadowMap.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX/UploadBuffer.h
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
