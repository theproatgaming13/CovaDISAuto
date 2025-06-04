using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Shared.DTO.Auto
{
    internal class CreateAuto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [JsonPropertyName("auto")]
        public string? merk { get; set; }
        public string? type { get; set; }
        public string? kleur { get; set; }
    }
}
