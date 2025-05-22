using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Domain.Entities
{
    public class Route
    {
        public int ID { get; set; }
        public string beginAdres { get; set; }
        public string eindAdres { get; set; }
        public double afstand { get; set; }
    }
}
