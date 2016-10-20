using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4PracticeConsole.Models;
using T4PracticeConsole.Template.Model;
using T4PracticeConsole.Utils;

namespace T4PracticeConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            UsePartial();
            UseParam();
            Console.WriteLine("click enter...");
            Console.ReadLine();
        }
        static ModelSampleData getData()
        {
            #region setSetting
            var setting = new CommonClassSetting();
            setting.Name = "CommonClassSetting";
            setting.NameSpace = "CodeGenerator.Models";
            #endregion

            #region setDetail
            var details = new List<ClassProperty>();
            details.Add(new ClassProperty() { Type = "String", Name = "Name" });
            details.Add(new ClassProperty() { Type = "String", Name = "NameSpace" });
            #endregion
            #region setData
            var data = new ModelSampleData();
            data.Setting = setting;
            data.Properties = details;
            #endregion
            return data;
        }

        static void outResult(String className,String outPath,String result) {
            Console.WriteLine(result);
            Console.WriteLine("press 'y' if confirm...");
            var key = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            if (key.Equals('y') || key.Equals('Y'))
            {
                //if(CommonUtil.CreateDirectoryIfNotExist)
                CommonUtil.CreateDirectoryIfNotExist(outPath);
                System.IO.File.WriteAllText(outPath + "/" + className + ".cs", result, Encoding.UTF8);
                Console.WriteLine("Generate...");
            }
        }
        static void UsePartial()
        {

            var outPath = "UsePartial";
            var data = getData();

            var sample = new ModelSamplePartial(data);
            var pageContent = sample.TransformText();
            outResult(data.Setting.Name, outPath, pageContent);
         
        }

        static void UseParam()
        {
            var outPath = "UseParam";
            var data = getData();

            var sample = new ModelSampleParam();
            sample.Session = new Dictionary<String, object>();

            var session = sample.Session;
            session["SampleData"] = data;
            // Add other parameter values to t.Session here.
            sample.Initialize(); // Must call this to transfer values.
            string pageContent = sample.TransformText();

            outResult(data.Setting.Name, outPath, pageContent);
        }
    }
}
