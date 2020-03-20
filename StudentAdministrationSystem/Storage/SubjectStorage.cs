using StudentAdministrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentAdministrationSystem.Storage
{
    public class SubjectStorage : DbContext
    {
        public SubjectStorage() : base("name=StudentAdminDb")
        {

        }

        public DbSet<Subject> Subjects { get; set; }

        public List<Subject> GetAllBut(List<Subject> subtract)
        {
            return Subjects.Except(subtract).ToList();
        }
    }

}
