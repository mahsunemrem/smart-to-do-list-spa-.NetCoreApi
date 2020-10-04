using Core.Utilities.Results;
using SmartToDoListAPI.Business.Services.Abstract;
using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.Services.Concrete
{
    public class UserManager : IUserService
    {
        public IResult Add(User model)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(User model)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Get(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetList(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
