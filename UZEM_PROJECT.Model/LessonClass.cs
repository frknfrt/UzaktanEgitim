using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM_PROJECT.Model
{
   public class LessonClass:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Video { get; set; }
        public string Slide { get; set; }
        public string Article { get; set; }
        public int CourseId { get; set; }
        public virtual CourseClass Course { get; set; }
    }
}
