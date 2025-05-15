using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Shared.DTO.Auto
{
    public class AutoListItem
    {
        public int id { get; set; }
        public string? merk { get; set; }
        public string? type { get; set; }
        public string? kleur { get; set; }
    }
}
