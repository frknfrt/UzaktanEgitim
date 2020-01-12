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
    public class MainTitleService : IMainTitleService
    {
        IMainTitleDAL _iMainTitleDAL;
        public void Delete(MainTitleClass entitiy)
        {
            _iMainTitleDAL.Remove(entitiy);
        }

        public void DeleteById(int entitiyID)
        {
            MainTitleClass mainTitleClass = _iMainTitleDAL.Get(a => a.ID == entitiyID);
            Delete(mainTitleClass);
        }

        public MainTitleClass Get(int entitiyID)
        {
            return _iMainTitleDAL.Get(a => a.ID == entitiyID);
        }

        public ICollection<MainTitleClass> GetAll()
        {
            return _iMainTitleDAL.GetAll().ToList();
        }

        public void Insert(MainTitleClass entitiy)
        {
            _iMainTitleDAL.Add(entitiy);
        }

        public void Update(MainTitleClass entitiy)
        {
            _iMainTitleDAL.Update(entitiy);
        }
    }
}
