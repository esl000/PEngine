cmake_minimum_required(VERSION 3.0)

project(Test)

source_group(testdir\\a FILES Sources/main.cpp Sources/main1.cpp Sources/main2.cpp)

add_executable(Test Sources/main.cpp Sources/main1.cpp Sources/main2.cpp)