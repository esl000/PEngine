using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class CoreModule : ProjectCMakeSetting
{
    public CoreModule() : base()
    {
        ProjectName = "CoreModule";
        IsLibrary = true;

        LinkedLibrarys.AddRange(new List<string>() {
            "RenderingModule",
            "Platform"
        });
    }
}