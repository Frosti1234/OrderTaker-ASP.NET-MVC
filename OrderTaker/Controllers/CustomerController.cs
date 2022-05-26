using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CustomerController : Controller
    {
        private readonly IBLCustomer blCustomer;

        public CustomerController(IBLCustomer customer)
        {
            this.blCustomer = customer;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return View(blCustomer.GetCustomers());
        }

        [HttpPost]
        public int Post(string name)
        {
            return blCustomer.AddCustomer(name);
        }
    }
}