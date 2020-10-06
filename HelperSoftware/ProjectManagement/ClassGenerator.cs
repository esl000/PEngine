using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneratorCore
{
    class ClassGenerator
    {
        public static readonly List<string> ClassFormKeyword = new List<string>()
        {
            "#classname#",
            "#parentclassname#",
            "#modulename#",
            "#uppermodulename#",
        };

        public static void CreateClassWithClassForm(string className, string parentClassName, string moduleName, List<string> classForms, string headerPath, string implementPath)
        {
            Dictionary<string, string> keywordMatchMap = new Dictionary<string, string>()
            {
                {ClassFormKeyword[0],  className},
                {ClassFormKeyword[1],  parentClassName},
                {ClassFormKeyword[2],  moduleName},
                {ClassFormKeyword[3],  moduleName.ToUpper()}
            };

            DirectoryInfo header = new DirectoryInfo(headerPath);
            DirectoryInfo implement = new DirectoryInfo(implementPath);

            if (!header.Exists) header.Create();
            if (!implement.Exists) implement.Create();

            File.WriteAllText(header.FullName + "\\" + className + ".h", ReplaceKeywordByForm(keywordMatchMap, classForms[0]));
            File.WriteAllText(implement.FullName + "\\" + className + ".cpp", ReplaceKeywordByForm(keywordMatchMap, classForms[1]));
        }

        public static string ReplaceKeywordByForm(Dictionary<string, string> keywordMatchMap, string form)
        {
            while (true)
            {
                bool findKeyword = false;

                foreach (var key in keywordMatchMap)
                {
                    int findIndex = form.IndexOf(key.Key);
                    if (findIndex < 0)
                    {
                        continue;
                    }

                    form = form.Remove(findIndex, key.Key.Length);
                    form = form.Insert(findIndex, key.Value);
                    findKeyword = true;
                }

                if (!findKeyword)
                    break;
            }

            return form;
        }

        public static void CreateDefaultClass(string className, string parentClassName, string headerPath, string implementPath)
        {
            bool isInheritToCreate = parentClassName.Length == 0 ? false : true;

            string header = "";
            header += "#pragma once\n\n";
            header += isInheritToCreate ?
                ("#include <" + parentClassName + ".h>\n\n") : "\n\n";
            header += "class " + className + (isInheritToCreate ?
                (" : public " + parentClassName + "\n") : "\n");
            header += "{\n\n";
            header += "public:\n";
            header += "\t" + className + "();\n";
            header += "\t~" + className + "();\n\n";
            header += "};\n";

            string implementCode = "";
            implementCode += "#include <" + className + ".h>\n\n";
            implementCode += className + "::" + className + "()\n";
            implementCode += isInheritToCreate ? ("\t: " + parentClassName + "()\n") : "";
            implementCode += "{\n\n\n";
            implementCode += "}\n\n";
            implementCode += className + "::~" + className + "()\n";
            implementCode += "{\n\n\n";
            implementCode += "}\n\n";

            DirectoryInfo headerDI = new DirectoryInfo(headerPath);
            DirectoryInfo implementDI = new DirectoryInfo(implementPath);

            if (!headerDI.Exists) headerDI.Create();
            if (!implementDI.Exists) implementDI.Create();

            File.WriteAllText(headerDI.FullName + "\\" + className + ".h", header);
            File.WriteAllText(implementDI.FullName + "\\" + className + ".cpp", implementCode);
        }
    }
}
