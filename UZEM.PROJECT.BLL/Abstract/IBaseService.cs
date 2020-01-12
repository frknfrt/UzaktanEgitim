using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM.PROJECT.BLL.Abstract
{
   public interface IBaseService<T>
        where T: BaseEntity
    {
        void Insert(T entitiy);
        void Delete(T entitiy);
        void DeleteById(int entitiyID);
        void Update(T entitiy);
        T Get(int entitiyID);
        ICollection<T> GetAll();
    }
}
