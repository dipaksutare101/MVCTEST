using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTEST.Models;
namespace MVCTEST.ViewModel
{
    public class CustomerViewModel
    {
        public Customer customer { get; set; }

        public List <Customer> customers { get; set; }

    }
}