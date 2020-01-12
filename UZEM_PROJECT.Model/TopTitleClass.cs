using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM_PROJECT.Model
{
   public class TopTitleClass:BaseEntity
    {
        public string Name { get; set; }
        public int MainTitleId { get; set; }
        public virtual List<CourseClass> Courses { get; set; }
    }
}
