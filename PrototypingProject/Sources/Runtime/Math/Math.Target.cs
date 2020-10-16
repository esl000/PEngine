using System;
using System.Collections.Generic;
using PEngineCMakeTool;

public class Math : ProjectCMakeSetting
{
	public Math() : base()
	{
		CmakeVersion = "3.1";
		ProjectName = "Math";
		IsLibrary = true;
		LinkedLibrarys.AddRange(new List<string>() {
			"Core"
		});
	}
}
