using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ЧЕрнова.Controllers
{
    //[RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View("Index");
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

        [ChildActionOnly]
        public int  ReturnFive()
        {
            return 5;
        }

        public ActionResult TheNewView()
        {
            return View();
        }

        public ActionResult ReturnEnteredDate(int year, int month,int date)
        {
            ViewBag.Message = new DateTime(year, month, date).ToShortDateString();
            return View();
        }

    }
}