using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class TestLibrary1 : ProjectCMakeSetting
{
    public TestLibrary1() : base()
    {
        ProjectName = "TestLibrary1";
        IsLibrary = true;
    }
}