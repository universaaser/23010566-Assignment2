using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicMVCProject.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The student name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a student name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9,\s]*$", ErrorMessage = "Please enter a student name made up of only letters, numbers and spaces")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The student address cannot be blank")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Please enter a student address between 10 and 200 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9,\s]*$", ErrorMessage = "Please enter a student address made up of only letters, numbers and spaces")]
        public string Address { get; set; }

        public int? CampusID { get; set; }
        public virtual Campus Campus { get; set; }
    }

}