using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebService1.Controllers
{
    public class HomeController : Controller
    {
        localhost.WebService1 ws =new localhost.WebService1();
        public ActionResult Index()
        {
            return View(ws.HelloWorld());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(localhost.Customer x)
        {
            return View(ws.Add(x));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}