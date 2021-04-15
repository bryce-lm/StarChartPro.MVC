using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Data
{
    public class Origin
    {
        [Key]
        public int OriginId { get; set; }

        [Required]
        public string OriginName { get; set; }
        
        public string OriginDescription { get; set; }
        
        [Required]
        public decimal Latitude { get; set; }
        
        [Required]
        public decimal Longitude { get; set; }

        [Required]
        public string OriginGalaxy { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
