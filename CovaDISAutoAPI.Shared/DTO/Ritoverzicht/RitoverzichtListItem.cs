using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Shared.DTO.Ritoverzicht
{
    public class RitoverzichtListItem
    {
        public int ID { get; set; }
        public int Kilometerstand_voor { get; set; }

        // Later verwijderen
        public int Chauffeur_id { get; set; }
        public int Route_id { get; set; }
    }
}
