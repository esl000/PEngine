using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class TestProject1 : ProjectCMakeSetting
{
    public TestProject1() : base()
    {
        ProjectName = "TestProject1";
        IsLibrary = false;
        LinkedLibrarys.AddRange(new List<string>() {
            "TestLibrary1",
            "TestLibrary2"
        });
    }
}