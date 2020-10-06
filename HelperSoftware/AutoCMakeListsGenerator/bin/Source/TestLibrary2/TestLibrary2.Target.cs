using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class TestLibrary2 : ProjectCMakeSetting
{
    public TestLibrary2() : base()
    {
        ProjectName = "TestLibrary2";
        IsLibrary = true;
    }
}