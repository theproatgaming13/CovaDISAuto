using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Domain.Entities
{
    public class Chauffeur
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public virtual Auto? Auto { get; set; }
        public virtual Route? Route { get; set; }
    }
}
