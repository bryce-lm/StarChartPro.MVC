using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarChartPro.Models.AstObjLocationModels
{
    public class AstObjLocationCreate
    {
        [Required]
        public int AstObjLocationId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        public string Galaxy { get; set; }

        [Required]
        public string DistanceFrmOrigin { get; set; }

        [Required]
        public string DistanceFromHost { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
