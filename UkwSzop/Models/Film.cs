using System.ComponentModel.DataAnnotations;

namespace UkwSzop.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(5000)]
        public string Desc { get; set; }

        public decimal Price { get; set; }

        public DateTime DateAdded { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
