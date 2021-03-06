﻿//Parker Mecham, Section 1

using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    //Class that sets and gets info for each book 
    public class Book
    {

        [Key]
        public int bookId { get; set; }

        [Required]
        public string Title { get; set; }

        //Name Variables
        [Required]
        public string AuthFirstName { get; set; }

        public string AuthMiddleName { get; set; }

        [Required]
        public string AuthLastName { get; set; }


        [Required]
        public int NumPages { get; set; }

        [Required]
        public string Publisher { get; set; }

        //Includes regular expression to validate the ISBN
        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{10}$")]
        public string ISBN { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public float Price { get; set; }


        //Variables to add the image and url locations
        public string Image { get; set; }

        public string PurchaseUrl { get; set; }

    }
}

