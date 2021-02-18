using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {

        [Key]
        public int bookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthFirstName { get; set; }

        public string? AuthMiddleName { get; set; }

        [Required]
        public string AuthLastName { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{10}$")]
        public string ISBN { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public float Price { get; set; }

    }
}

