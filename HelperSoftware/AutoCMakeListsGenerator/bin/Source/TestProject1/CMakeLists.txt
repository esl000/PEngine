cmake_minimum_required(VERSION 3.1)

project(TestProject1)

source_group(private private/main.cpp
)

source_group(public public/header.h
)

include_directories( E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestProject1/public
E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestLibrary1/public
E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestLibrary2/public
)

add_executable(TestProject1 E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestProject1/private/main.cpp
E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Source/TestProject1/public/header.h
)

target_link_libraries(TestProject1 TestLibrary1
TestLibrary2
)

add_definitions(-D_UNICODE)