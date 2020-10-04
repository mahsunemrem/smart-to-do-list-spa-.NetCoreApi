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
    public interface IToDoItemService
    {
        IDataResult<List<ToDoItemDto>> GetList(Expression<Func<ToDoItem, bool>> filter = null);
        IDataResult<ToDoItemDto> Get(Expression<Func<ToDoItem, bool>> filter = null);
        IResult Add(ToDoItemDto model);
        IResult Delete(ToDoItemDto model);
        IResult Update(ToDoItemDto model);
    }
}
