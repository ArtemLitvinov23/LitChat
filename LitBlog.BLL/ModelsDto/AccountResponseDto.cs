﻿using System;

namespace LitBlog.BLL.ModelsDto
{
    public class AccountResponseDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Verified { get; set; }
        public bool IsVerified { get; set; }
    }
}