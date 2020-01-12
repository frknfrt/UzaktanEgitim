using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM_PROJECT.Model
{
   public class UserClass:BaseEntity
    {
        public UserClass()
        {
            Role =(Role)1;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public Role Role { get; set; }
        public string CardName { get; set; }
        public string NameOnCard { get; set; }
        public string CardNo { get; set; }
        public string CardMonth { get; set; }

        public string CardYear { get; set; }
        public string CardCvc { get; set; }

        public virtual List<CourseClass> Courses { get; set; }
    }
public enum Role
{
    Admin=0,
    User=1,
    Instructor=2
}
}
