using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicMVCProject.Models
{
    public class Campus
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Campus Name")]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}