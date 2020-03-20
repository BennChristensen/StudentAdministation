using StudentAdministrationSystem.Models;
using StudentAdministrationSystem.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAdministrationSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentStorage _studentStorage = new StudentStorage();
        SubjectStorage _subjectStorage = new SubjectStorage();
        // GET: Student
        public ActionResult Index()
        {
            return View(_studentStorage.Students.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            _studentStorage.Students.Add(student);
            _studentStorage.SaveChanges();
            return View("Index", _studentStorage.Students.ToList());
        } 

        public ActionResult Details(int id)
        {
            Student student = _studentStorage.Students.Find(id);
            _studentStorage.Entry(student).Collection(s => s.Subjects ).Load();
            return View(_studentStorage.Students.Find(id));
        }

        [HttpGet]
        public ActionResult Enroll(int id)
        {
            EnrollStudentViewModel enrollStudent = new EnrollStudentViewModel();
            enrollStudent.Student = _studentStorage.Students.Find(id);
            enrollStudent.Subjects = _subjectStorage.GetAllBut(enrollStudent.Student.Subjects);
            return View(enrollStudent);
        }

        [HttpPost]
        public ActionResult Enroll(EnrollStudentViewModel enrollStudent)
        {
            Student student = _studentStorage.Students.Find(enrollStudent.Student.StudentId);
            Subject subject = _subjectStorage.Subjects.Find(enrollStudent.SelectedValue);
            student.Subjects.Add(subject);
            _studentStorage.SaveChanges();
            enrollStudent.SelectedSubject = subject;
            enrollStudent.Student = student;
            return View("EnrollDetails",enrollStudent);
        }
    }
}