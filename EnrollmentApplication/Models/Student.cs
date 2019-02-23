using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name ="Student ID")]
        public virtual int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public virtual String LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="First Name")]
        public virtual String FirstName { get; set; }
    }
}