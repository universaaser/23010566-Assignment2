using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicMVCProject.Models
{
    public class Campus
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The campus name cannot be blank")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter a campus name between 3 and 50 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a campus name beginning with a capital letter and enter only letters and spaces.")]
        [Display(Name = "Campus Name")]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }

}