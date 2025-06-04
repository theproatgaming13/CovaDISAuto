using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Domain.Entities
{
    public class Auto
    {
        public int id { get; set; }
        public string? merk { get; set; }
        public string? type { get; set; }
        public string? kleur { get; set; }
        public int medewerkerId { get; set; }
        public Medewerker? medewerker { get; set; }
    }
}
