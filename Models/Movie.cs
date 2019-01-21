using System.ComponentModel.DataAnnotations;

namespace moviemvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GenreId { get; set; }
        public string DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

    }

}