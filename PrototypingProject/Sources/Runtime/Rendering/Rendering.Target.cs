using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class Rendering : ProjectCMakeSetting
{
    public Rendering() : base()
    {
        ProjectName = "Rendering";
        IsLibrary = true;

        LinkedLibrarys.AddRange(new List<string>() {
            "Core"
        });
    }
}