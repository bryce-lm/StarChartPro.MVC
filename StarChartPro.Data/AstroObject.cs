using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Data
{
    public class AstroObject
    {
        [Key]
        public int AstObjId { get; set; }

        [Required]
        public string AstObjName { get; set; }

        [Required]
        public bool AstObjArtificial { get; set; }

        [Required]
        public string AstObjDesc { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
