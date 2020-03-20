using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentAdministrationSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Angiv venligst et navn")]
        [StringLength(20)]
        [DisplayName("Navn")]
        public string Name { get; set; }
        [DisplayName("e-mail adresse")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {
            Subjects = new List<Subject>();
        }
    }
}