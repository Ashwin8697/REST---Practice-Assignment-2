using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Bio { get; set; }

        public List<Book>? Books { get; set; }
    }
}