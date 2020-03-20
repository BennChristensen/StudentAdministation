using System.Collections.Generic;

namespace StudentAdministrationSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Student> EnrolledStudents { get; set; }
    }
}