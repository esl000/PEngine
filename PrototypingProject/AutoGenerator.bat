@echo off
cd PEngineCMakeGenerator
@echo:
AutoCMakeListsGenerator.exe
@echo off
cd ..
::IF EXIST "Project" rd "Project" /s /q
IF NOT EXIST "Project" md Project
cd Project
@echo:
cmake -G "Visual Studio 15 2017 Win64" ..\Sources
PAUSE