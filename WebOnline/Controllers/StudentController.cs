using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebOnline.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult capnhapthongtin()
        {
            return View();
        }
        public ActionResult chitietbaihoc()
        {
            return View();
        }
        public ActionResult chitietkhoahoc()
        {
            return View();
        }
        public ActionResult chitietkhoahoccuatoi()
        {
            return View();
        }
        public ActionResult doimatkhau()
        {
            return View();
        }
        public ActionResult thaoluan()
        {
            List<string> Listchuoi = new List<string>();
            Listchuoi.Add("Tại sao phải sử dụng mô hình MVC");
            Listchuoi.Add("Lập trình c# có dễ sử dụng");
            Listchuoi.Add("Ưu điểm của AngularJS");
            ViewBag.ListChuoi = Listchuoi;
            return View();
        }
        public ActionResult thongtincanhan()
        {
            return View();
        }
         public ActionResult khoahoccuatoi()
        {
            return View();
        }
	}
}