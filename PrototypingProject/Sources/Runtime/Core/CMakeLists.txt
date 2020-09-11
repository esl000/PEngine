cmake_minimum_required(VERSION 3.1)

project(CoreModule)

source_group(Private Private/PEngineCore.cpp
)

source_group(Public Public/PEngineCore.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
)

add_library(CoreModule E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Private/PEngineCore.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/PEngineCore.h
)

target_link_libraries(CoreModule RenderingModule
Platform
)

add_definitions(-D_UNICODE)