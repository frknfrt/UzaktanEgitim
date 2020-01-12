using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM.PROJECT.Dal.Abstract;
using UZEM_PROJECT.Core.DAL.EntityFramework;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.Dal.Concrete.EntityFramework
{
   public class InstructorRepository : EFRepositoryBase<InstructorClass, UzemProjectDbContext>, IInstructorDAL
    {
    }
}
