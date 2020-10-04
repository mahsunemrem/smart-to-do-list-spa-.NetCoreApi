using Core.Utilities.Results;
using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.Services.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetList(Expression<Func<User, bool>> filter = null);
        IDataResult<User> Get(Expression<Func<User, bool>> filter = null);
        IResult Add(User model);
        IResult Delete(User model);
        IResult Update(User model);
    }
}
