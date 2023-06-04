using System;
using System.Collections.Generic;

namespace ReservationApp.Models
{
    public partial class Accammodation
    {
        public Accammodation()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public short? Floor { get; set; }
        public string? Adress { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
