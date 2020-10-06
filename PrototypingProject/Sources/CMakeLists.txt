cmake_minimum_required(VERSION 3.1)

project(PEngine)

add_subdirectory(Player/WindowPlayer)
add_subdirectory(Runtime/Core)
add_subdirectory(Runtime/MathModule)
add_subdirectory(Runtime/Platform)
add_subdirectory(Runtime/Rendering)

set_property(DIRECTORY E:/Main/PEngine/PrototypingProject/Sources PROPERTY VS_STARTUP_PROJECT PEngineWindowPlayer)

