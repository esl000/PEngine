using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class RenderingModule : ProjectCMakeSetting
{
    public RenderingModule() : base()
    {
        ProjectName = "RenderingModule";
        IsLibrary = true;
    }
}