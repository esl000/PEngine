using System.Collections.Generic;

namespace PEngineCMakeTool
{
    public class SolutionCMakeSetting
    {
        public string CmakeVersion { get; set; }
        public string SolutionName { get; set; }
        public string MainProjectName { get; set; }
        public List<string> SubProjectName { get; set; }

        public SolutionCMakeSetting()
        {
            CmakeVersion = "3.1";
            SolutionName = "SampleSolution";
            SubProjectName = new List<string>();
        }
    }

    public class ProjectCMakeSetting
    {
        public string CmakeVersion { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDirectory { get; set;}
        public bool IsLibrary { get; set; }

        public List<string> IncludeDirectorys { get; protected set; }
        public List<string> LinkedLibrarys { get; protected set; }

        public ProjectCMakeSetting()
        {
            CmakeVersion = "3.1";
            ProjectName = "SampleProject";
            IsLibrary = true;

            IncludeDirectorys = new List<string>();
            LinkedLibrarys = new List<string>();
        }
    }
}
