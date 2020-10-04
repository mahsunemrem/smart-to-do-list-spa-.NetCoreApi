using Core.DataAccess;
using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.DataAccess.Abstract
{
    public interface IToDoTitleDal : IEntityRepository<ToDoTitle>
    {

    }
}
