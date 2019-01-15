using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;
using moviemvc.Models;

namespace moviemvc.Controllers
{
    public class CustomersController : Controller
    {

        private readonly ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
           _context = context;

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers;

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }


    }
}