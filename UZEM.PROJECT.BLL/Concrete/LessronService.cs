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
    public class LessronService : ILessonService
    {
        ILessonDAL _lessonDAL;
        public LessronService(ILessonDAL lessonDAL)
        {
            _lessonDAL = lessonDAL;
        }
        public void Delete(LessonClass entitiy)
        {
            _lessonDAL.Remove(entitiy);
        }

        public void DeleteById(int entitiyID)
        {
            LessonClass lessonClass = _lessonDAL.Get(a => a.ID == entitiyID);
            Delete(lessonClass);
        }

        public LessonClass Get(int entitiyID)
        {
            return _lessonDAL.Get(a => a.ID == entitiyID);
        }

        public ICollection<LessonClass> GetAll()
        {
            return _lessonDAL.GetAll().ToList();
        }

        public void Insert(LessonClass entitiy)
        {
            _lessonDAL.Add(entitiy);
        }

        public void Update(LessonClass entitiy)
        {
            _lessonDAL.Update(entitiy);
        }
    }
}
