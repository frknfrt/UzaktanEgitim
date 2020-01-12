using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM_PROJECT.Model
{
   public class InstructorClass:BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string AccountNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkedinAddress { get; set; }
        public string PromotionalVideo { get; set; }
        public string Cv { get; set; }
        public virtual List<CourseClass> Courses { get; set; }
    }
}
