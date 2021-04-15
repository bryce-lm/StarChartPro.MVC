using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Data
{
    public class AstObjLocation
    {
        [Key]
        public int AstObjLocationId { get; set; }

        [Required]
        public string Galaxy { get; set; }

        [Required]
        public string DistanceFrmOrigin { get; set; }
            
        [Required]
        public string DistanceFromHost { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
