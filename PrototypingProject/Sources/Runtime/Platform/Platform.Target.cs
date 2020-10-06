using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class Platform : ProjectCMakeSetting
{
    public Platform() : base()
    {
        ProjectName = "Platform";
        IsLibrary = true;

        LinkedLibrarys.AddRange(new List<string>() {
            "CoreModule"
        });
    }
}