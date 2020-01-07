using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Lib;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult ProductCategory()
        {
            var model = new ProductCategoryLib().ListAll();
            return PartialView(model);
        }

        public ActionResult Category(long cateId)
        {
            var category = new CategoryLib().ViewDetail(cateId);
            return View(category);
        }

        [OutputCache(CacheProfile = "Cache1DayForProduct")]
        public ActionResult Detail(long id)
        {
            var product = new ProductLib().ViewDetail(id);
            ViewBag.Category = new ProductCategoryLib().ViewDetail(product.CategoryID.Value);
            ViewBag.RelatedProducts = new ProductLib().ListRelatedProducts(id);
            return View(product);
        }
    }
}