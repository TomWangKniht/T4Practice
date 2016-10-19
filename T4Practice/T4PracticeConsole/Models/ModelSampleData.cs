using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4PracticeConsole.Models
{
    public class ModelSampleData
    {
        public string Name => Setting.Name;
        public string NameSpace => Setting.NameSpace;
        public CommonClassSetting Setting { get; set; }
        public List<ClassProperty> Properties { get; set; }
    }
}
