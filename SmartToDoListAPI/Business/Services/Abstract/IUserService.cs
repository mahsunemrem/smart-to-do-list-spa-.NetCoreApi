using Core.Utilities.Results;
using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.Services.Abstract
{
    public interface IUserService
    {
        IDataResult<List<UserDto>> GetList(Expression<Func<User, bool>> filter = null);
        IDataResult<UserDto> Get(Expression<Func<User, bool>> filter = null);
        IResult Add(UserDto model);
        IResult Delete(UserDto model);
        IResult Update(UserDto model);
        IDataResult<UserDto> GetByMail(string email);
    }
}
