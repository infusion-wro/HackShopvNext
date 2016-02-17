using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackShopvNext.Models;
using Microsoft.AspNet.Mvc;

namespace HackShopvNext.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult Shop()
        {
            ViewBag.Message = "Buy some vodka.";

            //return View(new Purchase(){VodkaPrice = 70.0});
            return View(new Purchase() { VodkaPrice = 70.0 });
        }


        [HttpPost]
        public ActionResult Shop(Purchase purchase)
        {
            if (ModelState.IsValid == false)
            {
                return View(purchase);
            }
            return Json(string.Format("You bought {0} vodkas for {1} ", purchase.VodkaCount, purchase.VodkaCount * purchase.VodkaPrice));
        }
    }
}
