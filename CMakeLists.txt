cmake_minimum_required(VERSION 4.3)
project(AllAboutThatBraille C)

set(CMAKE_C_STANDARD 11)

add_subdirectory(C:/raylib/raylib raylib)

add_executable(AllAboutThatBraille main.c)

target_link_libraries(AllAboutThatBraille raylib)