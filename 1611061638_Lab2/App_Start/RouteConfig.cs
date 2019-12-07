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
               name: "Danh sách bài viết",
               url: "bai-viet/danh-sach-bai-viet",
               defaults: new { controller = "New", action = "Danhsachbaiviet", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Bài viết",
              url: "bai-viet/chi-tiet-{id}",
              defaults: new { controller = "New", action = "ChiTiet", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
