using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);

        }
        public IActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
           { new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}
