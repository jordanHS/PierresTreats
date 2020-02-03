namespace PierresTreats.Models
{
  public class TreatFlavor
    {       
        public int CategoryItemId { get; set; }
        public int TreatId { get; set; }
        public int FlavorId { get; set; }
        public Treat Treat { get; set; }
        public Flavor Flavor { get; set; }
    }
}