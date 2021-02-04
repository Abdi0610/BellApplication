using System;
using System.ComponentModel.DataAnnotations;

namespace BellApp.Models
{
    public class EmployeeModel
    {     
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter First Name ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]     
        [Required(ErrorMessage = "Please Enter Last Name ")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please Enter Date of Birth ")]
        public Nullable<System.DateTime> DateofBirth { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address ")]
        public string Address { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Enter Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}