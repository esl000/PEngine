using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement
{
    class ModuleGenerator
    {
        public static void CreateModule(string parentPath, string moduleName)
        {
            DirectoryInfo di = new DirectoryInfo(Path.Combine(parentPath, moduleName));
            if (di.Exists)
                return;

            di.Create();
            di.CreateSubdirectory("Public");
            di.CreateSubdirectory("Private");

            string targetCSData =
                "using System;\n" +
                "using System.Collections.Generic;\n" +
                "using PEngineCMakeTool;\n" +
                "\n" +
                "public class " + moduleName + " : ProjectCMakeSetting\n" +
                "{\n" +
                "\tpublic " + moduleName + "() : base()\n" +
                "\t{\n" +
                "\t\tCmakeVersion = \"3.1\";\n" +
                "\t\tProjectName = \"" + moduleName + "\";\n" +
                "\t\tIsLibrary = true;\n" +
                "\t\tLinkedLibrarys.AddRange(new List<string>() {\n" +
                "\t\t\t\n" +
                "\t\t});\n" +
                "\t}\n" +
                "}\n";

            string moduleDefineHeader =
                "#pragma once\n" +
                "\n" +
                "#ifdef _EDITABLE_PROJECT\n" +
                "#define " + moduleName.ToUpper() + "API __declspec(dllexport)\n" +
                "#else\n" +
                "#define " + moduleName.ToUpper() + "API __declspec(dllimport)\n" +
                "#endif\n" +
                "\n";

            string moduleDefineImplement =
                "#include <" + moduleName + "Define.h>\n" +
                "\n";

            File.WriteAllText(Path.Combine(di.FullName, moduleName + ".Target.cs"), targetCSData);
            File.WriteAllText(Path.Combine(di.FullName, "Public", moduleName + "Define.h"), moduleDefineHeader);
            File.WriteAllText(Path.Combine(di.FullName, "Private", moduleName + "Define.cpp"), moduleDefineImplement);
        }
    }
}
