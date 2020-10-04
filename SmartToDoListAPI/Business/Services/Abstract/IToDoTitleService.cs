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
    public interface IToDoTitleService
    {
        IDataResult<List<ToDoTitleDto>> GetList(Expression<Func<ToDoTitle, bool>> filter = null);
        IDataResult<ToDoTitleDto> Get(Expression<Func<ToDoTitle, bool>> filter = null);
        IResult Add(ToDoTitleDto model);
        IResult Delete(ToDoTitleDto model);
        IResult Update(ToDoTitleDto model);
    }
}
