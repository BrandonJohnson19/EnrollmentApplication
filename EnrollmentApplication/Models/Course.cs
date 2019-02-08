using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        public virtual String Title { get; set; }
        public virtual String Description { get; set; }
        public virtual int CourseCredits { get; set; }
    }
}