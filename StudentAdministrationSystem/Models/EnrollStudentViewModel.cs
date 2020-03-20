using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAdministrationSystem.Models
{
    public class EnrollStudentViewModel
    {
        public Student Student { get; set; }
        public List<Subject> Subjects { get; set; }
        public int SelectedValue { get; set; }
        public Subject SelectedSubject { get; set; }
        public SelectList SelectList { 
            get { return new SelectList(Subjects, nameof(Subject.SubjectId), nameof(Subject.Name)); }
        }
    }
}