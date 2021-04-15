using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Models.AstroObjModels
{
    public class AstroObjEdit
    {
        public int AstObjId { get; set; }
        public string AstObjName { get; set; }
        public bool AstObjArtificial { get; set; }
        public string AstObjDesc { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
