namespace BasicMVCProject.Migrations
{
    using BasicMVCProject.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BasicMVCProject.Data.BasicMVCProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BasicMVCProject.Data.BasicMVCProjectContext context)
        {
            var campuses = new List<Campus>
            {
                new Campus { Name = "Campus A" },
                new Campus { Name = "Campus B" }
            };
            campuses.ForEach(c => context.Campus.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student { Name = "Student 1", Address = "Address 1", Campus = campuses.Single(c => c.Name == "Campus A") },
                new Student { Name = "Student 2", Address = "Address 2", Campus = campuses.Single(c => c.Name == "Campus B") }
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}
