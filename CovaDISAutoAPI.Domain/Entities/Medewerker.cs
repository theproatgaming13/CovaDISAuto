using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Domain.Entities
{
    public class Medewerker
    {
        public int id { get; set; }
        public string? naam { get; set; }
        public string? functie { get; set; }
        public string? email { get; set; }
        public string? telefoonnummer { get; set; }
        public List<Auto>? autos { get; set; } = new List<Auto>();
    }
}
