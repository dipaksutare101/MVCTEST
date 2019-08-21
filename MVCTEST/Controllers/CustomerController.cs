using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTEST.Models;
using MVCTEST.DAL;

namespace MVCTEST.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer(Customer obj)
        {

            CustomerDAL DAL = new CustomerDAL();
            DAL.Customers.Add(obj);
            DAL.SaveChanges();
            List<Customer> objListCust = DAL.Customers.ToList<Customer>();


            //Customer obj = new Customer  { CustomerCode ="dip1001",CustomerName ="Dipak" };

            return View(objListCust);
        }

        public ActionResult Enter()
        {
            return View();
        }
    }
}