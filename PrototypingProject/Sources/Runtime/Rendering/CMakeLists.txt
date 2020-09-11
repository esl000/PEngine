cmake_minimum_required(VERSION 3.1)

project(RenderingModule)

source_group(Private Private/Test.cpp
)

source_group(Public Public/Test.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
)

add_library(RenderingModule E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Private/Test.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public/Test.h
)

add_definitions(-D_UNICODE)