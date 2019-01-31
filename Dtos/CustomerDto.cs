using System;
using System.ComponentModel.DataAnnotations;
using moviemvc.Models;

namespace moviemvc.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }
        
        public string Birthdate { get; set; }
    }
}