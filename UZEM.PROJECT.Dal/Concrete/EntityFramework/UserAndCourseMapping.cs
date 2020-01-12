using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.Dal.Concrete.EntityFramework
{
   public class UserAndCourseMapping: EntityTypeConfiguration<UserAndCourseClass>
    {
        public UserAndCourseMapping()
        {
            HasKey(a => new { a.UserId, a.CourseId });
        }
    }
}
