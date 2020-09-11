using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class PEngine : SolutionCMakeSetting
{
    public PEngine() : base()
    {
        SolutionName = "PEngine";
        MainProjectName = "PEngineWindowPlayer";

        SubProjectName.AddRange(new List<string>()
        {
            "Platform",
            "RenderingModule",
            "PEngineWindowPlayer",
            "CoreModule"
        });
    }
}
