﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Domain.Entities
{
    public class Ritoverzicht
    {
        public int ID { get; set; }
        public int Kilometerstand_voor { get; set; }
        public virtual Chauffeur? Chauffeur { get; set; }
        public virtual Route? Route { get; set; }
    }
}
