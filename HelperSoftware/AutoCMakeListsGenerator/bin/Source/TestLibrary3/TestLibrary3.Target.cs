using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class TestLibrary3 : ProjectCMakeSetting
{
    public TestLibrary3() : base()
    {
        ProjectName = "TestLibrary3";
        IsLibrary = true;
    }
}