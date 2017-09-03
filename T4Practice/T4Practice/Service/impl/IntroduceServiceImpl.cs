using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T4Practice.Models.ViewModel;
using T4Practice.Service.api;

namespace T4Practice.Service.impl
{
    public class IntroduceServiceImpl : IIntroduceService
    {
        public IEnumerable<ReferenceViewModel> getReferences()
        {
            var result = new List<ReferenceViewModel>();
            var datas = getData();
            foreach (var data in datas)
            {
                result.Add(new ReferenceViewModel()
                {
                    Name = data[0],
                    Url = data[1],
                    Description = data[2]
                });
            }

            return result;
        }

        private List<String[]> getData()
        {
            var result = new List<String[]>();
            result.Add(new String[] { "程式碼產生和 T4 文字範本", "https://msdn.microsoft.com/zh-tw/library/bb126445.aspx", "MSDN教學(推薦)" });
            result.Add(new String[] { "Devart T4 Editor for Visual Studio", "https://visualstudiogallery.msdn.microsoft.com/a42a8538-8d6e-491b-8097-5a8a00174d37", "相關編輯外掛" });
            result.Add(new String[] { "客製化MVC Scaffolding Template – SideWaffle ", "http://vmiv.blogspot.tw/2015/01/mvc-scaffolding-template-sidewaffle.html", "介紹SideWaffle的使用" });
            result.Add(new String[] { "CODE-利用T4依XML產生多個資料物件", "http://blog.darkthread.net/post-2013-03-15-t4-multiple-files.aspx", "設計階段範本的使用" });
            

            return result;
        }
    }
}