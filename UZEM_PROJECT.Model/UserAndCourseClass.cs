using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UZEM_PROJECT.Model
{
   public class UserAndCourseClass
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
        public CourseClass Course { get; set; }
        public UserClass User { get; set; }
    }
}
