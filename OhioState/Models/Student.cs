using System;
using System.Collections.Generic;

namespace OhioState.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// Navigation properties are typically defined as virtual so that they can take advantage 
        ///  of certain Entity Framework functionality, such as lazy loading. 
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}