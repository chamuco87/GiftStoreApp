using System;
using System.Collections.Generic;

namespace GiftStoreApp.Models
{
    public partial class Users
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
