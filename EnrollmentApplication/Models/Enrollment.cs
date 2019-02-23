using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }

        [Required]
        [RegularExpression("A-Fa-f", ErrorMessage = "Please enter a grade from A - F")]
        public virtual string Grade { get; set; }

        public virtual string StudentObject { get; set; }
        public virtual string CourseObject { get; set; }

        [Required]
        [Display(Name ="Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required]
        [Display(Name ="Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required]
        [RegularExpression("2018-2019", ErrorMessage ="Please enter in 2018 or 2019")]
        public virtual int EnrollmentYear { get; set; }
        public virtual bool IsActive { get; set; }
    }
}