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
    public class UserService : IUserService
    {
        IUserDAL _userDAL;
        public UserService(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void Delete(UserClass entitiy)
        {
            _userDAL.Remove(entitiy);
        }

        public void DeleteById(int entitiyID)
        {
            UserClass userClass = _userDAL.Get(a => a.ID == entitiyID);
            Delete(userClass);

        }

        public UserClass Get(int entitiyID)
        {
           return _userDAL.Get(a => a.ID == entitiyID);
        }

        public ICollection<UserClass> GetAll()
        {
            return _userDAL.GetAll().ToList();
        }

        public UserClass GetUserByLogin(string email, string password)
        {
            return _userDAL.Get(a => a.Email == email && a.Password == password);
        }

        public void Insert(UserClass entitiy)
        {
            _userDAL.Add(entitiy);
        }

        public void Update(UserClass entitiy)
        {
            _userDAL.Update(entitiy);
        }
    }
}
