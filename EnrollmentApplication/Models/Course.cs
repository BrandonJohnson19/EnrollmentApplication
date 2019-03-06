using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name ="Course ID")]
        public virtual int CourseId { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name ="Course Title")]
        public virtual String Title { get; set; }

        public virtual String Description { get; set; }

        [Required]
        [Range(1,4)]
        [Display(Name ="Number of credits")]
        public virtual int CourseCredits { get; set; }

        public virtual String InstructorName { get; set; }
    }
}