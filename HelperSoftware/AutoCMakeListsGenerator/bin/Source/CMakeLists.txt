cmake_minimum_required(VERSION 3.1)

project(DebugTest)

add_subdirectory(TestLibrary1)
add_subdirectory(TestLibrary2)
add_subdirectory(TestProject1)

set_property(DIRECTORY E:/Main/PEngine/TestProjects/AutoCMakeListsGenerator/bin/Debug/../Source PROPERTY VS_STARTUP_PROJECT TestProject1)

