using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using PEngineCMakeTool;

using System.CodeDom.Compiler;
using System.Reflection;

namespace AutoCMakeListsGenerator
{
    public static class CMakeUtility
    {
        public static string SetCMakeVersion(string version)
        {
            return "cmake_minimum_required(VERSION " + version + ")\n\n";
        }
        public static string SetProjectName(string projectName) { return "project(" + projectName + ")\n\n"; }
        public static string AddSubdirectory(List<string> childPath)
        {
            string data = "";

            foreach (var path in childPath)
            {
                data += "add_subdirectory(" + path + ")\n";
            }

            data += "\n";

            return data;
        }
        public static string SetBinaryCodes(string projectName, List<string> codeFiles)
        {
            if (codeFiles == null || codeFiles.Count == 0)
                return "";

            string cmakeCommands = "add_executable(" + projectName + " WIN32 ";
            foreach(var filePath in codeFiles)
            {
                cmakeCommands += filePath + "\n";
            }
            cmakeCommands += ")\n\n";
            return cmakeCommands;
        }
        public static string SetSourceGroup(string projectDirectory, List<FileInfo> codeFiles)
        {
            Dictionary<string, string> sourceGroupSet = new Dictionary<string, string>();

            foreach(var scrFile in codeFiles)
            {
                string sourceGroupPath = GetSpecificRelativePath(projectDirectory, scrFile.Directory.FullName);
                if(sourceGroupSet.ContainsKey(sourceGroupPath))
                {
                    sourceGroupSet[sourceGroupPath] += GetRelativePath(projectDirectory, scrFile.FullName) + "\n";
                }
                else
                {
                    sourceGroupSet[sourceGroupPath] = GetRelativePath(projectDirectory, scrFile.FullName) + "\n";
                }
            }

            string data = "";

            foreach(var groupPair in sourceGroupSet)
            {
                data += "source_group(" + groupPair.Key + " " + groupPair.Value + ")\n\n";
            }

            return data;
        }

        public static string SetIncludeDirectory(HashSet<string> sourcePaths)
        {
            if (sourcePaths == null || sourcePaths.Count == 0)
                return "";

            string data = "include_directories( ";

            foreach(var dir in sourcePaths)
            {
                data += dir + "\n";
            }

            data += ")\n\n";

            return data;
        }

        public static string SetLinkLibrary(ProjectCMakeSetting settingData)
        {
            if (settingData.LinkedLibrarys.Count == 0)
                return "";

            string data = "target_link_libraries(" + settingData.ProjectName + " ";

            foreach (var libraryName in settingData.LinkedLibrarys)
            {
                data += libraryName + "\n";
            }

            data += ")\n\n";

            return data;
        }


        public static string SetLibraryCodes(string projectName, List<string> codeFiles)
        {
            if (codeFiles == null || codeFiles.Count == 0)
                return "";

            string cmakeCommands = "add_library(" + projectName + " ";
            foreach (var filePath in codeFiles)
            {
                cmakeCommands += filePath + "\n";
            }
            cmakeCommands += ")\n\n";
            return cmakeCommands;
        }

        public static string GetRelativePath(string relativeTo, string path, char directorySeparator = '/')
        {
            var uri = new Uri(relativeTo);
            var rel = Uri.UnescapeDataString(uri.MakeRelativeUri(new Uri(path)).ToString()).Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            rel = rel.Replace(Path.AltDirectorySeparatorChar, directorySeparator);
            return rel.Substring(rel.IndexOf(directorySeparator, 0) + 1); 
        }

        public static string GetSpecificRelativePath(string relativeTo, string path, string directorySeparator = "\\\\")
        {
            var uri = new Uri(relativeTo);
            var rel = Uri.UnescapeDataString(uri.MakeRelativeUri(new Uri(path)).ToString()).Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            rel = rel.Substring(rel.IndexOf(Path.AltDirectorySeparatorChar, 0) + 1);
            return rel.Replace("/", "\\\\");
        }

        public static string SetProjectCharacterSet()
        {
            return "add_definitions(-D_UNICODE)";
        }

        public static string SetStartProject(string currentDirectory, string projectName)
        {
            return "set_property(DIRECTORY " + currentDirectory.Replace(Path.DirectorySeparatorChar, 
                Path.AltDirectorySeparatorChar) +
                " PROPERTY VS_STARTUP_PROJECT " + projectName + ")\n\n";
        }

        public static void FindSourceFiles(DirectoryInfo current, List<string> extensions, List<FileInfo> sourcefiles)
        {
            DirectoryInfo[] dInfos = current.GetDirectories();
            FileInfo[] targetFiles = current.GetFiles("*.*");
            targetFiles = targetFiles.Where((f) => extensions.Contains(f.Extension)).ToArray();

            if (targetFiles != null && targetFiles.Length != 0)
                sourcefiles.AddRange(targetFiles);

            if (dInfos == null || dInfos.Length == 0)
                return;

            foreach (var di in dInfos)
            {
                FindSourceFiles(di, extensions, sourcefiles);
            }
        }
    }

    public class ProjectProperty
    {
        public ProjectCMakeSetting SettingClass { get; protected set; }
        public DirectoryInfo ProjectDirectory { get; protected set; }
        public List<FileInfo> SourceFiles { get; protected set; }
        public HashSet<string> SourceIncludePath { get; protected set; }
        public List<string> SourcePath { get; protected set; }

        public ProjectProperty(FileInfo targetFile, ProjectCMakeSetting settingClass)
        {
            ProjectDirectory = targetFile.Directory;
            SettingClass = settingClass;

            List<string> extensions = new List<string>() { ".cpp", ".h" };

            SourceFiles = new List<FileInfo>();

            CMakeUtility.FindSourceFiles(ProjectDirectory, extensions, SourceFiles);

            if (SourceFiles.Count == 0)
                return;

            SourceIncludePath = new HashSet<string>();
            SourcePath = new List<string>();

            foreach (var dir in SettingClass.IncludeDirectorys)
            {
                SourceIncludePath.Add(dir);
            }

            foreach (var fi in SourceFiles)
            {
                string filePath = fi.FullName.Replace(Path.DirectorySeparatorChar,
                    Path.AltDirectorySeparatorChar);
                SourcePath.Add(filePath);

                string fileDirectory = fi.Directory.FullName.Replace(Path.DirectorySeparatorChar,
                    Path.AltDirectorySeparatorChar);
                if (fi.Extension == ".h")
                    SourceIncludePath.Add(fileDirectory);
            }
        }

        public void ReferencingOtherProject(List<ProjectProperty> allProjectProperties)
        {
            List<ProjectProperty> linkedProjects = allProjectProperties.Where
                (pp => SettingClass.LinkedLibrarys.Contains(pp.SettingClass.ProjectName)).ToList();

            foreach(var property in linkedProjects)
            {
                foreach(var dir in property.SourceIncludePath)
                {
                    SourceIncludePath.Add(dir);
                }
            }
        }

        public void CreateCMakeFile()
        {
            string data = "";

            data += CMakeUtility.SetCMakeVersion(SettingClass.CmakeVersion);
            data += CMakeUtility.SetProjectName(SettingClass.ProjectName);
            data += CMakeUtility.SetSourceGroup(ProjectDirectory.FullName, SourceFiles);
            data += CMakeUtility.SetIncludeDirectory(SourceIncludePath);
            data += SettingClass.IsLibrary ?
                CMakeUtility.SetLibraryCodes(SettingClass.ProjectName, SourcePath) :
                CMakeUtility.SetBinaryCodes(SettingClass.ProjectName, SourcePath);
            data += CMakeUtility.SetLinkLibrary(SettingClass);
            data += CMakeUtility.SetProjectCharacterSet();

            File.WriteAllText(ProjectDirectory.FullName + "\\CMakeLists.txt", data);

        }

    }

    public class Core
    {
        public string StartRelativePath { get; set; }

        public void LoadConfig()
        {
            string data = File.ReadAllText(Directory.GetCurrentDirectory() + "\\config.txt");
            StartRelativePath = data.Split('\n')[0];
        }

        public void Start()
        {
            LoadConfig();
            CreateCMakeList();
        }

        public void CreateCMakeList()
        {
            List<FileInfo> projectFiles = new List<FileInfo>();

            string startPath = Path.Combine(Directory.GetCurrentDirectory(), StartRelativePath);

            DirectoryInfo startPathDI = new DirectoryInfo(startPath);

            FileInfo solutionFile = startPathDI.GetFiles("*.Target.Main.cs")[0];

            FindCSFiles(startPathDI, projectFiles);

            List<ProjectCMakeSetting> settingClasses = GetProjectCMakeSettingClass(solutionFile, projectFiles,
                out SolutionCMakeSetting solutionClass);

            List<string> usedProjectPaths = new List<string>();
            List<ProjectProperty> allProjectProperties = new List<ProjectProperty>();

            for (int i = 0; i < projectFiles.Count; ++i)
            {
                if (solutionClass.SubProjectName.Contains(settingClasses[i].ProjectName))
                {
                    usedProjectPaths.Add(CMakeUtility.GetRelativePath(startPath, projectFiles[i].Directory.FullName));
                    allProjectProperties.Add(new ProjectProperty(projectFiles[i], settingClasses[i]));
                }
            }

            foreach(var property in allProjectProperties)
            {
                property.ReferencingOtherProject(allProjectProperties);
            }

            foreach (var property in allProjectProperties)
            {
                property.CreateCMakeFile();
            }

            string data = CMakeUtility.SetCMakeVersion(solutionClass.CmakeVersion);
            data += CMakeUtility.SetProjectName(solutionClass.SolutionName);
            data += CMakeUtility.AddSubdirectory(usedProjectPaths);
            data += CMakeUtility.SetStartProject(startPath, solutionClass.MainProjectName);

            File.WriteAllText(startPath + "\\CMakeLists.txt", data);
        }


        public List<ProjectCMakeSetting> GetProjectCMakeSettingClass(FileInfo solutionFile, List<FileInfo> csFiles, out SolutionCMakeSetting solutionClass)
        {
            List<string> csfilePaths = new List<string>();

            csfilePaths.Add(solutionFile.FullName);

            foreach (var csFile in csFiles)
            {
                csfilePaths.Add(csFile.FullName);
            }

            CompilerParameters cp = new CompilerParameters()
            {
                GenerateExecutable = false, // compile as library (dll)
                OutputAssembly = "Compiled_ProjectSetting.dll",
                GenerateInMemory = true, // as a physical file
            };

            cp.ReferencedAssemblies.Add("System.dll");
            cp.ReferencedAssemblies.Add(Assembly.GetAssembly(typeof(ProjectCMakeSetting)).Location);

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerResults results = provider.CompileAssemblyFromFile(cp, csfilePaths.ToArray());

            List<ProjectCMakeSetting> settingClasses = new List<ProjectCMakeSetting>();

            Type solutionClassType = results.CompiledAssembly.GetType(solutionFile.Name.Split('.')[0]);
            solutionClass = Activator.CreateInstance(solutionClassType) as SolutionCMakeSetting;

            foreach (var csFile in csFiles)
            {
                Type targetType = results.CompiledAssembly.GetType(csFile.Name.Split('.')[0]);
                settingClasses.Add(Activator.CreateInstance(targetType) as ProjectCMakeSetting);
            }

            return settingClasses;
        }

        public void FindCSFiles(DirectoryInfo current, List<FileInfo> csfiles)
        {
            DirectoryInfo[] dInfos = current.GetDirectories();
            FileInfo[] targetFiles = current.GetFiles("*.Target.cs");

            if (targetFiles != null && targetFiles.Length != 0)
                csfiles.AddRange(targetFiles);

            if (dInfos == null || dInfos.Length == 0)
                return;

            foreach (var di in dInfos)
            {
                FindCSFiles(di, csfiles);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Core().Start();
        }
    }
}
