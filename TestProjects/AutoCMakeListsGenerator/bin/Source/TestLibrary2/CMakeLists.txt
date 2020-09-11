cmake_minimum_required(VERSION 3.1)

project(TestLibrary2)

source_group(private private/main.cpp
)

source_group(public public/header.h
)

include_directories( E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestLibrary2/public
)

add_library(TestLibrary2 E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestLibrary2/private/main.cpp
E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestLibrary2/public/header.h
)

add_definitions(-D_UNICODE)