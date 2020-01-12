using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM_PROJECT.Model
{
   public class CourseClass:BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string PromotionVideo { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public string RequirementList { get; set; }
        public string Announcement { get; set; }
        public Level Level { get; set; }
        public int TopTitleId { get; set; }
        public int MainTitleId { get; set; }
        public bool IsActive { get; set; }      
        public TopTitleClass TopTitle { get; set; }
        public MainTitleClass MainTitle { get; set; }
        public virtual List<InstructorClass> Instructors { get; set; }
        public virtual List<LessonClass> Lessons { get; set; }
        public virtual List<UserClass> Users { get; set; }        
    }
    public enum Level
    {
        Beginner,
        Medium,
        Advanced,
        All
    }
}
