cmake_minimum_required(VERSION 3.1)

project(CoreModule)

source_group(Private FILES Private/PEngineCore.cpp
)

source_group(Private\\Base FILES Private/Base/PEngineMacros.cpp
)

source_group(Public FILES Public/PEngineCore.h
)

source_group(Public\\Base FILES Public/Base/PEngineMacros.h
)

add_library(CoreModule E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/CoreModule.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Private/PEngineCore.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Private/Base/PEngineMacros.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/PEngineCore.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base/PEngineMacros.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/Windows
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX
)

target_link_libraries(CoreModule RenderingModule
Platform
)

add_definitions(-D_EDITABLE_PROJECT)
add_definitions(-D_UNICODE)
