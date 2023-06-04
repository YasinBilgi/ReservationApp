using System;
using System.Collections.Generic;

namespace ReservationApp.Models
{
    public partial class ContactU
    {
        public short Id { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public string? Description { get; set; }
    }
}
