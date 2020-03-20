using StudentAdministrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace StudentAdministrationSystem.Storage
{
    public class StudentStorage : DbContext
    {
        public StudentStorage() : base("name=StudentAdminDb")
        {

        }
        public DbSet<Student> Students { get; set; }
    }        
}