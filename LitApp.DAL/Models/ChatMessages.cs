﻿using System;

namespace LitApp.DAL.Models
{
    public class ChatMessages
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public int FromUserId { get; set; }

        public string FromEmail { get; set; }

        public Account FromUser { get; set; }

        public int ToUserId { get; set; }

        public string ToEmail { get; set; }

        public Account ToUser { get; set; }
    }
}
