namespace moviemvc.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GenreId { get; set; }
        public string DateAdded { get; set; }
        public string ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }

    }

}