using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Models.AstroObjModels
{
    public class AstroObjList
    {
        public int AstObjId { get; set; }

        [Required]
        public string AstObjName { get; set; }

        public bool AstObjArtificial { get; set; }
        public string AstObjDesc { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
