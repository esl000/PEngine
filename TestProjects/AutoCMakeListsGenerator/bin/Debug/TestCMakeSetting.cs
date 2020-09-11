using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class TestCMakeSetting : ProjectCMakeSetting
{
    public TestCMakeSetting() : base()
    {
        ProjectName = "TestProject";
        IsLibrary = true;
    }
}