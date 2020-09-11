cmake_minimum_required(VERSION 3.1)

project(PEngineWindowPlayer)

source_group(Private Private/Main.cpp
)

include_directories( E:/Main/PEngine/PrototypingProject/Sources/Runtime/Core/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Platform/Public
E:/Main/PEngine/PrototypingProject/Sources/Runtime/Rendering/Public
)

add_executable(PEngineWindowPlayer WIN32 E:/Main/PEngine/PrototypingProject/Sources/Player/WindowPlayer/Private/Main.cpp
)

target_link_libraries(PEngineWindowPlayer RenderingModule
Platform
CoreModule
)

add_definitions(-D_UNICODE)