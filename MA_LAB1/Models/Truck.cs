using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MA_LAB1.Models
{
    public class Truck
    {

        public int TruckID { get; set; }
        [Required(ErrorMessage = "Please Enter Your Truck Model")]
        public string t_model { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Your Truck Make")]
        public string t_make { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Your RouteID")]
        public int RouteID { get; set; }

    }
}
