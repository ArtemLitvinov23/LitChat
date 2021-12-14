﻿using System.Collections.Generic;

namespace LitBlazor.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string JwtToken { get; set; }
        public ICollection<ChatMessage> MessagesFromUser { get; set; }
        public ICollection<ChatMessage> MessagesToUser { get; set; }
    }
}
