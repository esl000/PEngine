cmake_minimum_required(VERSION 3.1)

add_executable(Source 
Public/DirectXModuleTest.h
Public/framework.h
Public/targetver.h
Private/DirectXModuleTest.cpp)

include_directories(${CMAKE_CURRENT_SOURCE_DIR}/Public)