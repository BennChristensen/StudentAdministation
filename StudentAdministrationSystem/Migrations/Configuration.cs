namespace StudentAdministrationSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAdministrationSystem.Storage.StudentStorage>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StudentAdministrationSystem.Storage.StudentStorage";
        }

        protected override void Seed(StudentAdministrationSystem.Storage.StudentStorage context)
        {
            //  This method will be called after migrating to the latest version.
            //context.Students.Find(8).PhoneNumber="Hello";
            //context.Students.AddOrUpdate(new Models.Student { StudentId=1,  Name = "HAN-SOLO", Email = "Han@eaaa.dk", PhoneNumber = "1234" });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
