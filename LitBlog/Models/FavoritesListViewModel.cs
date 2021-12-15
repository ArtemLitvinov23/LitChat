﻿using System.ComponentModel.DataAnnotations;

namespace LitChat.API.Models
{
    public class FavoritesListViewModel
    {
        public int AccountId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
