using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          //  routes.MapRoute(
          //     name: "capnhapthongtin",
          //     url: "capnhapthongtin",
          //     defaults: new { controller = "Home", action = "capnhapthongtin", id = UrlParameter.Optional }
          // );
          //  routes.MapRoute(
          //    name: "thaoluan",
          //    url: "thaoluan",
          //    defaults: new { controller = "Home", action = "thaoluan", id = UrlParameter.Optional }
          //);
            routes.MapRoute(
            name: "capnhapthongtin",
            url: "capnhapthongtin",
            defaults: new { controller = "Student", action = "capnhapthongtin", id = UrlParameter.Optional }
        );
            routes.MapRoute(
             name: "chitietbaihoc",
             url: "chitietbaihoc",
             defaults: new { controller = "Student", action = "chitietbaihoc", id = UrlParameter.Optional }
         );
            routes.MapRoute(
            name: "chitietkhoahoccuatoi",
            url: "chitietkhoahoccuatoi",
            defaults: new { controller = "Student", action = "chitietkhoahoccuatoi", id = UrlParameter.Optional }
        );
            routes.MapRoute(
           name: "dangkymonhoc",
           url: "dangkymonhoc",
           defaults: new { controller = "Student", action = "dangkymonhoc", id = UrlParameter.Optional }
       );
            routes.MapRoute(
          name: "doimatkhau",
          url: "doimatkhau",
          defaults: new { controller = "Student", action = "doimatkhau", id = UrlParameter.Optional }
      );
            routes.MapRoute(
         name: "thongtincanhan",
         url: "thongtincanhan",
         defaults: new { controller = "Student", action = "thongtincanhan", id = UrlParameter.Optional }
     );
            routes.MapRoute(
              name: "thaoluan",
              url: "thaoluan",
              defaults: new { controller = "Student", action = "thaoluan", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "khoahoccuatoi",
              url: "khoahoccuatoi",
              defaults: new { controller = "Student", action = "khoahoccuatoi", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
