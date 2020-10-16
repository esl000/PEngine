cmake_minimum_required(VERSION 3.1)

project(Math)

source_group(Private FILES Private/MathDefine.cpp
Private/Vector.cpp
)

source_group(Public FILES Public/MathDefine.h
Public/Vector.h
)

add_library(Math E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Math.Target.cs
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Private/MathDefine.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Private/Vector.cpp
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Public/MathDefine.h
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Public/Vector.h
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Math/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public/Base
)

target_link_libraries(Math Core
)

add_definitions(-D_EDITABLE_PROJECT)
add_definitions(-D_UNICODE)
