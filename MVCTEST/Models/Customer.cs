﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTEST.Models
{
    public class Customer
    {
        [Key]
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
    }
}