using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Model.EF;
using Model.Lib;
using OnlineShop.Common;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public int CartSession { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Slides = new SlideLib().ListAll();
            var productLib = new ProductLib();
            ViewBag.NewProducts = productLib.ListNewProduct(4);
            ViewBag.ListFeatureProducts = productLib.ListFeatureProduct(4);
            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult MainMenu()
        {
            var model = new MenuLib().ListByGroupId(1);
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult TopMenu()
        {
            var model = new MenuLib().ListByGroupId(2);
            return PartialView(model);
        }

        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return PartialView(list);
        }
        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult Footer()
        {
            var model = new FooterLib().GetFooter();
            return PartialView(model);
        }
    }

   
}