using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM.PROJECT.Dal.Concrete.EntityFramework;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.Dal.Concrete
{
   public class UzemProjectDbContext:DbContext
    {
        public UzemProjectDbContext() : base(@"Server=.;Database=UzemProjectDb;Integrated Security=true;")
        {
            Database.SetInitializer<UzemProjectDbContext>(new MyStrategy());
        }
        public DbSet<CourseClass> Courses { get; set; }
        public DbSet<InstructorClass> Instructors { get; set; }
        public DbSet<IntructorAndCourseClass> IntructorAndCourses { get; set; }
        public DbSet<LessonClass> Lessons { get; set; }
        public DbSet<MainTitleClass> MainTitles { get; set; }
        public DbSet<TopTitleClass> TopTitles { get; set; }
        public DbSet<UserAndCourseClass> UserAndCourses { get; set; }
        public DbSet<UserClass> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new IntructorAndCourseMapping());
            modelBuilder.Configurations.Add(new UserAndCourseMapping());
        }
    }

    class MyStrategy : DropCreateDatabaseIfModelChanges<UzemProjectDbContext>
    {
        protected override void Seed(UzemProjectDbContext context)
        {
            var topTitles = new List<TopTitleClass>
            {
                new TopTitleClass{ Name="Programlama Dilleri"},
                new TopTitleClass{ Name="Donanımsal Diller"},
                new TopTitleClass{ Name="WebForms"},
                new TopTitleClass{ Name="MSSQL"},
                new TopTitleClass{ Name="Encapsulation"},
            };

            var mainTitles = new List<MainTitleClass>
            {
                new MainTitleClass{ Name="Yazılım"},
                new MainTitleClass{ Name="Donanım"},
                new MainTitleClass{ Name="Web Tasarımı"},
                new MainTitleClass{ Name="Database Yönetimi"},
                new MainTitleClass{ Name="OOP Prensipleri"}
            };

            var courses = new List<CourseClass>
            {
                new CourseClass{Name="Java", TopTitle=topTitles.Single(t=>t.Name=="Programlama Dilleri"), MainTitle=mainTitles.Single(m=>m.Name=="Yazılım"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="C#", TopTitle=topTitles.Single(t=>t.Name=="Programlama Dilleri"), MainTitle=mainTitles.Single(m=>m.Name=="Yazılım"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="PHP", TopTitle=topTitles.Single(t=>t.Name=="Programlama Dilleri"), MainTitle=mainTitles.Single(m=>m.Name=="Yazılım"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="C++", TopTitle=topTitles.Single(t=>t.Name=="Programlama Dilleri"), MainTitle=mainTitles.Single(m=>m.Name=="Yazılım"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="Assembly", TopTitle=topTitles.Single(t=>t.Name=="Donanımsal Diller"), MainTitle=mainTitles.Single(m=>m.Name=="Donanım"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="Asp.Net WebForms", TopTitle=topTitles.Single(t=>t.Name=="WebForms"), MainTitle=mainTitles.Single(m=>m.Name=="Web Tasarımı"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="Stored Prodecure", TopTitle=topTitles.Single(t=>t.Name=="MSSQL"), MainTitle=mainTitles.Single(m=>m.Name=="Database Yönetimi"), Photo="/Content/placeholder.gif"},

                new CourseClass{Name="Verileri Sınırlama Prensibi", TopTitle=topTitles.Single(t=>t.Name=="Encapsulation"), MainTitle=mainTitles.Single(m=>m.Name=="OOP Prensipleri"), Photo="/Content/placeholder.gif"}
            };

            context.MainTitles.AddRange(mainTitles);
            context.TopTitles.AddRange(topTitles);
            context.Courses.AddRange(courses);
            context.SaveChanges();
        }
    }
}
