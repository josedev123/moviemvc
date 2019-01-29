using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreNotes;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;
using moviemvc.Models;

namespace moviemvc.Controllers
{
    [Route("api/[controller]")]
    public class ApiCustomersController: Controller
{
        private ApplicationDbContext _context;
        public ApiCustomersController(ApplicationDbContext context)
        {
           _context = context;

        }
        //get /api/apicustomers
        [HttpGet("")]
        public IEnumerable<Customer> GetCustomers()
        {
           return _context.Customers.ToList();
        }

        //get /api/apicustomers/1
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.Find(id);

            if(customer == null)
            {
                return null;
            }
                

            return customer;  


        }


        //POST /api/apicustomers/
        [HttpPost]
        public Customer PostCustomer([FromBody] Customer customer)
        {
            if(!ModelState.IsValid)
                return null;


            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        // put

        [HttpPut("{id}")]
        public Customer PutCustomer(int id, [FromBody] Customer customer)
        {
            if(!ModelState.IsValid)
                return null;

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id ==id);

            if(customerInDb == null)
            return null;

            customerInDb.Name = customer.Name;
            customerInDb.Birthdate = customer.Birthdate;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();
            return customer;
        }

        [HttpDelete("{id}")]
        public Customer DeleteCustomer(int id)
        {

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id ==id);

            if(customerInDb == null)
            return null;

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return customerInDb;
        }



    }
}