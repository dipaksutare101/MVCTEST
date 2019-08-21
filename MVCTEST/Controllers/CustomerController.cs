using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTEST.Models;

namespace MVCTEST.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer()
        {
            Customer obj = new Customer  { CustomerCode ="dip1001",CustomerName ="Dipak" };
            return View(obj);
        }
    }
}