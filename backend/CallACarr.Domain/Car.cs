namespace CallACarr.Domain
{
    public class Car : EntityBase
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Seats { get; set; }
        public string Kenteken { get; set; }
    }
}