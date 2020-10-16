cmake_minimum_required(VERSION 3.1)

project(Core)

source_group(Private FILES Private/CoreDefine.cpp
Private/PEngineCore.cpp
)

source_group(Private\\Base FILES Private/Base/PEngineMacros.cpp
)

source_group(Public FILES Public/CoreDefine.h
Public/PEngineCore.h
)

source_group(Public\\Base FILES Public/Base/PEngineMacros.h
)

add_library(Core E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Core.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Private/CoreDefine.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Private/PEngineCore.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Private/Base/PEngineMacros.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/CoreDefine.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/PEngineCore.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base/PEngineMacros.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/DirectX
)

target_link_libraries(Core Rendering
)

add_definitions(-D_EDITABLE_PROJECT)
add_definitions(-D_UNICODE)
