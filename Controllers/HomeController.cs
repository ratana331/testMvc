using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Same Name
        public ActionResult Index() //action method
        {
            ViewBag.Name = "Show Your Home Page";
            return View(); 
        }
        //Different Name
        public ActionResult ShowInfo()
        {
            return View("Show");
        }
        //In Shared Folder
        public ActionResult Detail()
        {
            return View("Details");
        }
        //Different Controller
        public ActionResult ShowMoreDetail()
        {
            return View("-/Views/About/Index.cshtml");
        }
        //redirect result
        public RedirectResult ShowInternal()
        {
            return Redirect("/Home/Index");
        }
        public RedirectResult ShowExternal()
        {
            return Redirect("https://www.google.com");
        }
    }
}