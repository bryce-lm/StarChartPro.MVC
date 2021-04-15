using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Models.OriginModels
{
    public class OriginEdit
    {
        public int OriginId { get; set; }

        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]

        public string OriginName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string OriginDesc { get; set; }

        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        public string OriginGalaxy { get; set; }
        
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
