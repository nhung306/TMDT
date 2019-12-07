using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1611061638_Lab2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Danh sách danh mục",
               url: "danh-muc/danh-sach-danh-muc",
               defaults: new { controller = "Category", action = "Danhsachdanhmuc", id = UrlParameter.Optional }
           );

           routes.MapRoute(
             "Danh mục",
             "danh-muc/chi-tiet-danh-muc-{id}",
             new { controller = "Category", action = "ChiTiet" }, new {id = @"d\+"}
        );

            routes.MapRoute(
               name: "Danh sách bài viết",
               url: "bai-viet/danh-sach-bai-viet",
               defaults: new { controller = "New", action = "Danhsachbaiviet" }
           );

          routes.MapRoute(
               "Bài viết",
               "bai-viet/{alias}-{id}",
               new { controller = "New", action = "ChiTiet" }, new {id= @"\d+"}
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
