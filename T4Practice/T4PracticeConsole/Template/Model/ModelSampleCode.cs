using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4PracticeConsole.Models;

namespace T4PracticeConsole.Template.Model
{

    public partial class ModelSamplePartial
    {
        private ModelSampleData SampleData;
        public ModelSamplePartial(ModelSampleData data)
        {
            this.SampleData = data;
        }
    }
}
