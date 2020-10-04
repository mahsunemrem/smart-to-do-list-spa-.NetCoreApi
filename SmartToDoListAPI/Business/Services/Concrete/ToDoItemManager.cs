using AutoMapper;
using Core.Utilities.Results;
using SmartToDoListAPI.Business.Services.Abstract;
using SmartToDoListAPI.DataAccess.Abstract;
using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.Services.Concrete
{
    
    public class ToDoItemManager : IToDoItemService
    {

        private readonly IToDoItemDal _toDoItemDal;
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public ToDoItemManager(IToDoItemDal toDoItemDal, IMapper mapper, IUserDal userDal)
        {
            _mapper = mapper;
            _toDoItemDal = toDoItemDal;
            _userDal = userDal;
        }
        public IResult Add(ToDoItemDto model)
        {
            var entity = _mapper.Map<ToDoItem>(model);
            _toDoItemDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(ToDoItemDto model)
        {
            var entity = _mapper.Map<ToDoItem>(model);
            _toDoItemDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<ToDoItemDto> Get(Expression<Func<ToDoItem, bool>> filter = null)
        {

            var dto = _mapper.Map<ToDoItemDto>(_toDoItemDal.Get(filter));
            return new SuccessDataResult<ToDoItemDto>(dto);
        }

        public IDataResult<List<ToDoItemDto>> GetList(Expression<Func<ToDoItem, bool>> filter = null)
        {
  
            var dtoList = _mapper.Map<List<ToDoItemDto>>(_toDoItemDal.GetList(filter).ToList());
            return new SuccessDataResult<List<ToDoItemDto>>(dtoList);
        }

        public IResult Update(ToDoItemDto model)
        {
            var entity = _mapper.Map<ToDoItem>(model);
            _toDoItemDal.Update(entity);
            return new SuccessResult();
        }
    }
}
