using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            //View Data



            List<string> student = new List<string>();
            student.Add("Vikash");
            student.Add("Sumit");
            student.Add("Amit");
            //ViewData["Students"] = student;
            //ViewData["Message"] = "I am a message";


            //view Bag
            //ViewBag.Students = student;

            TempData["Students"] = student;
            Session["messgae"] = "Hi i am session";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Submit()
        {

            var sample = TempData["Students"];
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}