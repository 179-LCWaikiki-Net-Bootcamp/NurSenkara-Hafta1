using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Range(1, 10)]
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
