using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UZEM_PROJECT.Model
{
   public class IntructorAndCourseClass
    {
        public int IntructorId { get; set; }
        public int CourseId { get; set; }
        public InstructorClass Instructor { get; set; }
        public CourseClass Course { get; set; }

    }
}
