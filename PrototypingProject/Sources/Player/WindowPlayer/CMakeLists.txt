cmake_minimum_required(VERSION 3.1)

project(PEngineWindowPlayer)

source_group(Private FILES Private/Main.cpp
)

add_executable(PEngineWindowPlayer WIN32 E:/Main/PEngine/PrototypingProject/Sources/Player/WindowPlayer/PEngineWindowPlayer.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Player/WindowPlayer/Private/Main.cpp
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
E:/Main/PEngine/PrototypingProject/Sources/Runtime/MathModule/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/Windows
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX
)

target_link_libraries(PEngineWindowPlayer MathModule
RenderingModule
Platform
CoreModule
)

add_definitions(-D_UNICODE)
