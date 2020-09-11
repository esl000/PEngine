cmake_minimum_required(VERSION 3.1)

project(Platform)

source_group(Private Private/WindowInstance.cpp
Private/WindowPlatformInterface.cpp
)

source_group(Public Public/WindowHeader.h
Public/WindowInstance.h
Public/WindowPlatformInterface.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public
)

add_library(Platform E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Private/WindowInstance.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Private/WindowPlatformInterface.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/WindowHeader.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/WindowInstance.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public/WindowPlatformInterface.h
)

add_definitions(-D_UNICODE)