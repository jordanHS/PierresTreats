using System.Collections.Generic;
namespace PierresTreats.Models
{
    public class Treats
    {
        public Treats()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

        public int TreatsId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TreatFlavor> Flavors { get; set; }
    }
}