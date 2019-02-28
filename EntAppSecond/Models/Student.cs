using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class Student
    {
        [Required (ErrorMessage = "Please Enter a valid Student ID")]
        [Display (Name = "Student I.D.")]
        [RegularExpression(@"(s|S)\d{7}")]
        public string StudentID { get; set; } = "";

        [Required]
        [RegularExpression(@"\w{2,}")]
        [Display (Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required]
        [RegularExpression(@".{3,}")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Number of Modules")]
        [Range(1, Int32.MaxValue)]
        public int? NoOfModules { get; set; }

        [Required]
        [Range(50, 250)]
        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [Required]
        [Display(Name = "Email")]
        public EmailAddressAttribute Email { get; set; }

        [Required]
        [Display(Name = "Email Confirmation")]
        public EmailAddressAttribute EmailConfirmation { get; set; }
    }
}
