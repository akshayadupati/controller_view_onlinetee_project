using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TshirtOrderApp.Controllers
{
    public class MainStoreController : Controller
    {
        // GET: MainStore
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Checkout(string size, string color, int qty)
        {
            int perTeeCost = 50;
            int totalCost = qty * perTeeCost;

            ViewData["size"] = size;
            ViewData["color"] = color;
            ViewData["qty"] = qty;
            ViewData["totalcost"] = totalCost;

            return View();
        }
    }
}