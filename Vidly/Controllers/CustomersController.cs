using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Cust(int? id)
        {
            var customer = new Customer()
            {
                Id = 1,
                Name = "John Smith"
            };
            var secondCustomer = new Customer()
            {
                Id = 2,
                Name = "Mary Williams"
            };
            List<Customer> customers = new List<Customer>();
            customers.Add(customer);
            customers.Add(secondCustomer);

            return View(customers);
        }
    }
}