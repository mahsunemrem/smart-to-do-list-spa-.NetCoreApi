using Core.DataAccess.EntityFramework;
using SmartToDoListAPI.DataAccess.Abstract;
using SmartToDoListAPI.DataAccess.Concrete.EntityFramework.Contexts;
using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.DataAccess.Concrete.EntityFramework
{
    public class EfUser : EfEntityRepositoryBase<User, EfContext>, IUserDal
    {
    }
}
