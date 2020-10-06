cmake_minimum_required(VERSION 3.1)

project(MathModule)

source_group(Private FILES Private/MathModuleDefine.cpp
)

source_group(Public FILES Public/MathModuleDefine.h
)

add_library(MathModule E:/Main/PEngine/PrototypingProject/Sources/Runtime/MathModule/MathModule.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/MathModule/Private/MathModuleDefine.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/MathModule/Public/MathModuleDefine.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/MathModule/Public
)

add_definitions(-D_EDITABLE_PROJECT)
add_definitions(-D_UNICODE)
