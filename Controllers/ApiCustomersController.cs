using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreNotes;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;
using moviemvc.Dtos;
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
        public ActionResult<CustomerDto> GetCustomers()
        {
            var customerDtos = _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);    
        }

        //get /api/apicustomers/1
        [HttpGet("{id}")]
        public ActionResult<CustomerDto> GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer)); 
        }


        //POST /api/apicustomers/
        [HttpPost]
        public ActionResult<Customer> PostCustomer([FromBody] CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.GetDisplayUrl() + customer.Id), customerDto);
        }

        // put

        [HttpPut("{id}")]
        public ActionResult PutCustomer(int id, [FromBody] CustomerDto customerDto)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id ==id);

            if(customerInDb == null)
            return NotFound();

            Mapper.Map(customerDto, customerInDb);


            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id ==id);

            if(customerInDb == null)
            return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }



    }
}