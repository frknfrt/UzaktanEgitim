using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM.PROJECT.BLL.Abstract;
using UZEM.PROJECT.Dal.Abstract;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.BLL.Concrete
{
   public class InstructorService:IInstructorService
    {
        IInstructorDAL _InstructorDAL;
        public InstructorService(IInstructorDAL instructorDAL)
        {
            _InstructorDAL = instructorDAL;
        }
        public void Insert(InstructorClass entitiy)
        {
            _InstructorDAL.Add(entitiy);
        }

        public void Delete(InstructorClass entitiy)
        {
            _InstructorDAL.Remove(entitiy);
        }

        public void DeleteById(int entitiyID)
        {
            InstructorClass instructorClass = _InstructorDAL.Get(a => a.ID == entitiyID);
            Delete(instructorClass);
        }

        public void Update(InstructorClass entitiy)
        {
            _InstructorDAL.Update(entitiy);
        }

        public InstructorClass Get(int entitiyID)
        {
            return _InstructorDAL.Get(a => a.ID == entitiyID);
        }

        public ICollection<InstructorClass> GetAll()
        {
            return _InstructorDAL.GetAll().ToList();
        }

       
    }
}
