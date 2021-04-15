using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Models.AstroObjModels
{
    public class AstroObjCreate
    {
        [Required]
        public int AstObjId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string AstObjName { get; set; }

        public bool AstObjArtificial { get; set; }
        public string AstObjDesc { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
