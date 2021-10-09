using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);

        }
        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return View(customer);
        }

    }
}
