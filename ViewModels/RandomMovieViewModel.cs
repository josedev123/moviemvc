using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using moviemvc.Models;

namespace moviemvc.ViewModels 
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers {get; set;}
    }
}