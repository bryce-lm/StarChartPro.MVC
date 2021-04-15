using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Data
{
    public class AOLocation
    {
        [Key]
        public int AOLocationId { get; set; }

        [Required]
        public string Galaxy { get; set; }

        [Required]
        public string DistanceFrmOrigin { get; set; }
            
        [Required]
        public string DistanceFrmHost { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
