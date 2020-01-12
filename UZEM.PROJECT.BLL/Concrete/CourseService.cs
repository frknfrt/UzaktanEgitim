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
    public class CourseService :ICourseService
    {
        ICourseDAL  _courseDAL;
        public CourseService(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }
        public void Delete(CourseClass entitiy)
        {
            _courseDAL.Remove(entitiy);
        }

        public void DeleteById(int entitiyID)
        {
            CourseClass courseClass = _courseDAL.Get(a => a.ID == entitiyID);
            Delete(courseClass);
        }

        public CourseClass Get(int entitiyID)
        {
            return _courseDAL.Get(a => a.ID == entitiyID);
        }

        public ICollection<CourseClass> GetAll()
        {
            return _courseDAL.GetAll().ToList();
        }

        public void Insert(CourseClass entitiy)
        {
             _courseDAL.Add(entitiy);
        }

        public void Update(CourseClass entitiy)
        {
            _courseDAL.Update(entitiy);
        }
    }
}
