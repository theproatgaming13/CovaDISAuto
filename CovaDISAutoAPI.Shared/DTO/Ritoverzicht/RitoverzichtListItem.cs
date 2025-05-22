using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Shared.DTO.Ritoverzicht
{
    public class RitoverzichtListItem
    {
        public int ID { get; set; }
        public int Kilometerstand_voor { get; set; }
        public string Chauffeur { get; set; }
        public string Route { get; set; }
    }
}
