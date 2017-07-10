using EADProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EADProject.Controllers
{

      // [Authorize (Roles= "Admin , User"  )]

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Gallery()
        {
            FurnitureDBEntities1 obj = new FurnitureDBEntities1();

            //var productsList = ctx.Products.ToList();
            //  if (productsList == null)
            // {
            //productsList = new List<Product>();
            // }
            return View(obj.Galleries.ToList());
        }
        public ActionResult Services()
        {
            FurnitureDBEntities1 obj = new FurnitureDBEntities1();
            //var productsList = ctx.Products.ToList();
            //  if (productsList == null)
            // {
            //productsList = new List<Product>();
            // }
            return View(obj.Products.ToList());
        }
    }
}