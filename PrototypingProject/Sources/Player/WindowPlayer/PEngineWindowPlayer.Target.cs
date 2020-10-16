using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class PEngineWindowPlayer : ProjectCMakeSetting
{
    public PEngineWindowPlayer() : base()
    {
        CmakeVersion = "3.1";
        ProjectName = "PEngineWindowPlayer";
        IsLibrary = false;

        LinkedLibrarys.AddRange(new List<string>() {
            "Math",
            "Rendering",
            "Core"
        });
    }
}