using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebOnline.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            String ten = "Nguyễn Văn Bình";
            ViewBag.Ten = ten;
            return View();
        }

        public ActionResult capnhapthongtin()
        {
                return View();
        }

       
        public ActionResult Contact()
        {
            return View();
        }
    }
}