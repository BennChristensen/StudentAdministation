using StudentAdministrationSystem.Models;
using StudentAdministrationSystem.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAdministrationSystem.Controllers
{
    public class SubjectController : Controller
    {
        SubjectStorage _subjectStorage = new SubjectStorage();
        // GET: Subject
        public ActionResult Index()
        {
            return View(_subjectStorage.Subjects.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            _subjectStorage.Subjects.Add(subject);
            _subjectStorage.SaveChanges();
            return View(nameof(SubjectController.Index), _subjectStorage.Subjects.ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_subjectStorage.Subjects.Find(id));
        }


    }
}