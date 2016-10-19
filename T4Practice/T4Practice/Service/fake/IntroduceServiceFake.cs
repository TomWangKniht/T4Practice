using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T4Practice.Models.ViewModel;
using T4Practice.Service.api;

namespace T4Practice.Service.fake
{
    public class IntroduceServiceFake : IIntroduceService
    {
        public IEnumerable<ReferenceViewModel> getReferences()
        {
            var result = new List<ReferenceViewModel>();
            for (int i = 0; i < 5; i++)
            {
                result.Add(new ReferenceViewModel()
                {
                    Name = "Name" + i,
                    Url = "Url" + i
                });
            }
            return result;
        }
    }
}