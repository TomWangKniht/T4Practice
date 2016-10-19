using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T4Practice.Service.api;
using T4Practice.Service.impl;

namespace T4Practice.Controllers
{
    public class TeachController : Controller
    {
        private IIntroduceService introduceService;
        public TeachController()
        {
            introduceService = new IntroduceServiceImpl();
        }
        // GET: Teach
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowReference()
        {
            var data = introduceService.getReferences();
            return View(data);
        }
    }
}