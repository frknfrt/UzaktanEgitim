using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM.PROJECT.Dal.Abstract;
using UZEM.PROJECT.Dal.Concrete.EntityFramework;

namespace UZEM.PROJECT.BLL.Ninject
{
   public class CustomDALModel:NinjectModule
    {
        public override void Load()
        {
            Bind<ICourseDAL>().To<CourseRepository>();
            Bind<IInstructorDAL>().To<InstructorRepository>();
            Bind<ILessonDAL>().To<LessonRepository>();
            Bind<IMainTitleDAL>().To<MainTitleRepository>();
            Bind<ITopTitleDAL>().To<TopTitleRepository>();
            Bind<IUserDAL>().To<UserRepository>();
        }
    }
}
