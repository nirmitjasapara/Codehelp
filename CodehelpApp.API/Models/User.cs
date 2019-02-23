using System;
using System.Collections.Generic;

namespace CodehelpApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}