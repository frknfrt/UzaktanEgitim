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
    public class TopTitleService : ITopTitleService
    {
        ITopTitleDAL _topTitleDAL;
        public TopTitleService(ITopTitleDAL topTitleDAL)
        {
            _topTitleDAL = topTitleDAL;
        }
        public void Delete(TopTitleClass entitiy)
        {
            _topTitleDAL.Remove(entitiy);
        }

        public void DeleteById(int entitiyID)
        {
            TopTitleClass topTitleClass = _topTitleDAL.Get(a => a.ID == entitiyID);
            Delete(topTitleClass);
        }

        public TopTitleClass Get(int entitiyID)
        {
           return _topTitleDAL.Get(a => a.ID == entitiyID);
        }

        public ICollection<TopTitleClass> GetAll()
        {
            return _topTitleDAL.GetAll().ToList();
        }

        public void Insert(TopTitleClass entitiy)
        {
            _topTitleDAL.Add(entitiy);
        }

        public void Update(TopTitleClass entitiy)
        {
            _topTitleDAL.Update(entitiy);
        }
    }
}
