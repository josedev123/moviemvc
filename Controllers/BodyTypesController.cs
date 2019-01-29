using Microsoft.AspNetCore.Mvc;
using moviemvc.Models;

namespace moviemvc.Controllers
{
    public class BodyTypesController : Controller 
    {
        [HttpPost]
        [Route("api/BodyTypes/JsonStringBody")]
        public Customer JsonStringBody([FromBody] Customer customer)
        {
            return customer;
        }
    }
}