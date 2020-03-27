using System.Collections.Generic;

namespace Pierres.Models
{
  public class Patron
    {
        public Patron()
        {
          this.Flavors = new HashSet<Checkout>();
        }

        public int PatronId { get; set; }
        public string PatronName { get; set; }
         public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Checkout> Flavors { get; set; }
    }
}