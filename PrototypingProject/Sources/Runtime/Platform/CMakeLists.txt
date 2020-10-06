cmake_minimum_required(VERSION 3.1)

project(Platform)

source_group(Private\\Windows FILES Private/Windows/WindowHeader.cpp
Private/Windows/WindowInstance.cpp
Private/Windows/WindowPlatformInterface.cpp
)

source_group(Public\\Windows FILES Public/Windows/WindowHeader.h
Public/Windows/WindowInstance.h
Public/Windows/WindowPlatformInterface.h
)

add_library(Platform E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Platform.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Private/Windows/WindowHeader.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Private/Windows/WindowInstance.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Private/Windows/WindowPlatformInterface.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/Windows/WindowHeader.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/Windows/WindowInstance.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/Windows/WindowPlatformInterface.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/Windows
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
)

target_link_libraries(Platform CoreModule
)

add_definitions(-D_EDITABLE_PROJECT)
add_definitions(-D_UNICODE)
