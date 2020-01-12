﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Model;

namespace UZEM.PROJECT.BLL.Abstract
{
   public interface IUserService:IBaseService<UserClass>
    {
        UserClass GetUserByLogin(string email, string password);
    }
}
