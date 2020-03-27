using System.Collections.Generic;

namespace Pierres.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
            this.Patrons = new HashSet<Checkout>();
        }

        public int FlavorId { get; set; }
        public int TreatFlavorId { get; set; }
        public int PatronId { get; set; }
      
        public string FlavorName { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<TreatFlavor> Treats { get;}
        public ICollection<Checkout> Patrons { get;}
    }
}