using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMvc.Controllers
{
    public class DocsController : Controller
    {
        // GET: Docs
        public FileResult Show()
        { 
            return File(Server.MapPath("~/Content/myFile.txt"), "text/plain");
        }
        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/myFile.txt"), "text/plain", "MVC5.txt");
        }
    }
}