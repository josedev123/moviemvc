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
        public Customer PostCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
                return null;

            //var customerd =  customer;   
            var customerd =  new Customer{ Name ="John Smith+++",IsSubscribedToNewsletter=false,MembershipTypeId=1,Birthdate="6/6/2000"};   



            _context.Customers.Add(customerd);
            _context.SaveChanges();

            return customerd;
        }

    }
}