using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REV_TEST_2.Models;


namespace REV_TEST_2.Controllers
{
    public class MainController : Controller
    {
        public static int count = 0;

        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Rev model)
        {
            ViewData["ok"] = "HHHMMM fine";

            if (!ModelState.IsValid)
            {
                count++;
                ViewData["ok"] = "BOIII YOU GONNA LOSE " + count + "theet";
            }
            else
            {
                if (Session["sess"] == null)
                {
                    List<Rev> ll = new List<Rev>();
                    ll.Add(model);
                    Session["sess"] = ll; 
                }
                else
                {
                    List<Rev> red = Session["sess"] as List<Rev>;
                    red.Add(model);
                    Session["sess"] = red;
                }
            }

            return View();
        }

        public ActionResult _ppp()
        {
            return View();
        }

        public ActionResult p2()
        {
            return View();
        }
    }
}