using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class Core : ProjectCMakeSetting
{
    public Core() : base()
    {
        ProjectName = "Core";
        IsLibrary = true;

        LinkedLibrarys.AddRange(new List<string>() {
            "Rendering",
        });
    }
}