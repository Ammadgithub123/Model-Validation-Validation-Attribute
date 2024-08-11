using System.ComponentModel.DataAnnotations;

namespace ValidationExpression.NetCore.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is much needed")]
        //[StringLength(10, MinimumLength = 5, ErrorMessage = "Please Enter the Name between 5 & 10 length")]
        //[MaxLength(10)]
        [MinLength(3, ErrorMessage = "Minimum length must be 3")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        //[EmailAddress]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 50, ErrorMessage = "Please Enter the Age between 18 & 50")]
        public int? Age { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //[RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "UpperCase,LowerCase,Numbers,Symbols,Min 8 Chars")]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "ConfirmPassword is required")]
        //[Compare("Password", ErrorMessage = "Both Password must be same")]
        //[Display(Name = "Confirm Password")]
        //public string ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "Number is required")]
        //[RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$", ErrorMessage = "Invalid Phone No")]
        //public string PakNumber { get; set; }

        //[Required(ErrorMessage = "WebsiteUrl is required")]
        //[Url(ErrorMessage = "Invalid Url")]
        //public string WebSiteUrl { get; set; }

    }
}

