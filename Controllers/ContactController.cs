using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMvc.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public int add()
        {
            int a = 3;
            int b = 4;
            int s = a + b;
            return s;
        }
        public ContentResult showContent()
        {
            return Content("Hello");
        }
    }
}