using System.ComponentModel.DataAnnotations;

namespace moviemvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }
        
        public string Birthdate { get; set; }
    }
}