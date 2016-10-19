using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Practice.Models.ViewModel;

namespace T4Practice.Service.api
{
    public interface IIntroduceService
    {
        IEnumerable<ReferenceViewModel> getReferences();
    }
}
