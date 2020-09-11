using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class TestSolution : SolutionCMakeSetting
{
    public TestSolution() : base()
    {
        SolutionName = "DebugTest";
        MainProjectName = "TestProject1";

        SubProjectName.Add("TestProject1");
        SubProjectName.Add("TestLibrary1");
        SubProjectName.Add("TestLibrary2");
    }
}