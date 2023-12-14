﻿using System.ComponentModel.DataAnnotations;

namespace LenkieWebAPI.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        public int InventoryCount { get; set; }
    }
}
