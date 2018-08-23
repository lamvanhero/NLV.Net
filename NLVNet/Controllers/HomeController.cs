using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLVNet.Data.EF;
using NLVNet.Data.Repositories;

namespace NLVNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var repo = new AccountRepository();
            var lst = repo.GetAll();
            return View();
        }
    }
}
