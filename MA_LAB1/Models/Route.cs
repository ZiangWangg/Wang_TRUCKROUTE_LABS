using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MA_LAB1.Models
{
    public class Route
    {
      
        public int RouteID { get; set; }
        [Required(ErrorMessage = "Please Enter Your Route Name")]
        public string route_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Your Route Length")]
        public string r_length { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Your Route Pay Per Km")]
        public string r_pay_per_km { get; set; } = string.Empty;
    }
}
