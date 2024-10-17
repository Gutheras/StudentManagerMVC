using ContosoUniversity2.Models;
using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }                  
        public string LastName { get; set; }            
        public string FirstMidName { get; set; }         
        public DateTime EnrollmentDate { get; set; }     

        // Collection for the relationship with Enrollment
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
