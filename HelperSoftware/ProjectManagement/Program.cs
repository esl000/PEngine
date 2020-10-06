using System;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ProjectManagement
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Core.Instance.InitializeCore();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Core.MainForm = new Form1();
            Application.Run(Core.MainForm);
            Core.Instance.ReleaseCore();
        }
    }

    public class NameCodePair
    {
        public string name = "";
        public string header = "";
        public string implement = "";
    }

    public class SoftwareData
    {
        public string ProjectDirectory;
        public string ProjectSourceDirectory;
        public string ProjectOutputDirectory;
        public string LastClassWizardSearchPath;
        public List<NameCodePair> ClassFormData;

        public SoftwareData()
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            ProjectDirectory = di.Parent.FullName;
            ProjectSourceDirectory = Path.Combine(di.Parent.FullName, "Sources");
            ProjectOutputDirectory = Path.Combine(di.Parent.FullName, "Project");
            LastClassWizardSearchPath = Path.Combine(di.Parent.FullName, "Sources");
            ClassFormData = new List<NameCodePair>();
        }

        public static SoftwareData LoadData(FileInfo fi)
        {
            string dataTxt = File.ReadAllText(fi.FullName);
            return JsonConvert.DeserializeObject<SoftwareData>(dataTxt);
        }

        public static void SaveData(FileInfo fi, SoftwareData data)
        {
            File.WriteAllText(fi.FullName, JsonConvert.SerializeObject(data));
        }
    }


    public class Core
    {
        protected static Core _instance = null;

        public static Core Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Core();
                }

                return _instance;
            }
        }

        protected Core()
        {

        }

        public static Form1 MainForm { get; set; }

        public static SoftwareData AllData { get; protected set; }
        public static FileInfo DataPathInfo { get; protected set; }

        public static List<ClassPresetMaker> OpenEditorForms { get; protected set; }

        public void InitializeCore()
        {
            OpenEditorForms = new List<ClassPresetMaker>();

            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Data");

            if (!di.Exists)
                di.Create();

            DataPathInfo = new FileInfo(Directory.GetCurrentDirectory() + "\\Data\\Data.json");

            if (!DataPathInfo.Exists)
                AllData = new SoftwareData();
            else
                AllData = SoftwareData.LoadData(DataPathInfo);
        }

        public void ReleaseCore()
        {
            SoftwareData.SaveData(DataPathInfo, AllData);
        }

        public static void UpdateClassFormList()
        {
            MainForm.UpdateClassFormList();
        }

        public static void GenerateProjectSolution()
        {
            CMakeCore.CMakeManager.CreateCMakeList(AllData.ProjectSourceDirectory);

            DirectoryInfo di = new DirectoryInfo(AllData.ProjectOutputDirectory);

            if (!di.Exists)
                di.Create();

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();

            process.Start();
            process.StandardInput.Write("cd " + AllData.ProjectOutputDirectory + Environment.NewLine);
            process.StandardInput.Write("cmake -G \"Visual Studio 15 2017 Win64\" " + AllData.ProjectSourceDirectory + Environment.NewLine);
            process.StandardInput.Close();

            process.Close();
        }
    }
}
