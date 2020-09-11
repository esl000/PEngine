using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.CodeDom.Compiler;
using System.Reflection;

namespace RuntimeCompileCSfile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo fi = di.Parent.Parent.EnumerateDirectories().First((d)=>d.Name == "csdir").GetFiles("*.cs")[0];

            CompilerParameters cp = new CompilerParameters()
            {
                GenerateExecutable = false, // compile as library (dll)
                OutputAssembly = fi.Name + "Test.dll",
                GenerateInMemory = true, // as a physical file
            };

            cp.ReferencedAssemblies.Add("System.dll");

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerResults results = provider.CompileAssemblyFromFile(cp, fi.FullName);

            Type targetType = results.CompiledAssembly.GetType("Test");
            string output = (string)targetType.GetMethod("Show", BindingFlags.Static | BindingFlags.Public).Invoke(null, null);

            Console.WriteLine(output);
        }
    }
}
