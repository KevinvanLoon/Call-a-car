using System;

namespace CallACarr.Domain
{
    public class Reservation : EntityBase
    {
        public int carId { get; set; }
        public Car Car { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public int kmsDriven { get; set; } //should be filled after driving (for history)
    }
}