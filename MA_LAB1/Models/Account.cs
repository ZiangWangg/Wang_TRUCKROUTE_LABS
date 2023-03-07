using System.ComponentModel.DataAnnotations;

namespace MA_LAB1.Models
{
    public class Account
    {
        public int AccountID { get; set; }


        [Required(ErrorMessage = "Please Enter Your First Name")]
		public string Fname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your Last Name")]
		public string Lname { get; set; } = string.Empty;


        [RegularExpression("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}")]
        public string Email { get; set; } = string.Empty;

        [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$")]
		public string Phone { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your Password")]
		public string Password { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your Confirmation Password")]
		[Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
		public string CPassword { get; set; } = string.Empty;


    }
}
