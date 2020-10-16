cmake_minimum_required(VERSION 3.1)

project(PEngineWindowPlayer)

source_group(Private FILES Private/Main.cpp
)

add_executable(PEngineWindowPlayer WIN32 E:/Main/PEngine/PrototypingProject/Sources/Player/WindowPlayer/PEngineWindowPlayer.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Player/WindowPlayer/Private/Main.cpp
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX
)

target_link_libraries(PEngineWindowPlayer Math
Rendering
Core
)

add_definitions(-D_UNICODE)
