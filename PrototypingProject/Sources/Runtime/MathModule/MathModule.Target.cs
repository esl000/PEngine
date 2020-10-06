using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class MathModule : ProjectCMakeSetting
{
	public MathModule() : base()
	{
		CmakeVersion = "3.1";
		ProjectName = "MathModule";
		IsLibrary = true;
		LinkedLibrarys.AddRange(new List<string>() {
			
		});
	}
}
