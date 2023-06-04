﻿using System;
using System.Collections.Generic;

namespace ReservationApp.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? RegisterDate { get; set; }
        public bool? IsActive { get; set; }
        public string? Role { get; set; }
    }
}
