using System;

namespace CallACarr.Domain
{
    public class Payment : EntityBase
    {
        public string externId { get; set; }

        public DateTime Date { get; set; }

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public Decimal Amount { get; set; }
    }
}