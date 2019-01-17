using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;
using moviemvc.Models;
using moviemvc.ViewModels;

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
        
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipType;
            var viewModel = new CustomerFormViewModel 
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            _context.Customers.Add(customer);
            else
            {
                var CustomerInDb = _context.Customers.Single(c => c.Id == customer.Id);

               CustomerInDb.Name = customer.Name;
               CustomerInDb.Birthdate = customer.Birthdate;
               CustomerInDb.MembershipTypeId = customer.MembershipTypeId;
               CustomerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

             }
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Customers");
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
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            return NotFound();


            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipType
            };
            return View("CustomerForm", viewModel);

        }

    }
}