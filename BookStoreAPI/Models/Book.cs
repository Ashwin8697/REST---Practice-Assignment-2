using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string? Title { get; set; }

        [Range(1800, 2100)]
        public int PublicationYear { get; set; }

        public int AuthorId { get; set; }

        public Author? Author { get; set; }
    }
}