using System;
using System.Collections.Generic;

namespace ReservationApp.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int? AccammodationId { get; set; }
        public string FullName { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime? RegisterDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Accammodation? Accammodation { get; set; }
    }
}
