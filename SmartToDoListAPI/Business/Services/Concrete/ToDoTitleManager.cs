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
    public class ToDoTitleManager : IToDoTitleService
    {
        private readonly IToDoTitleDal _toDoTitleDal;
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
      
        public ToDoTitleManager(IToDoTitleDal toDoTitleDal, IMapper mapper, IUserDal userDal)
        {
            _mapper = mapper;
            _toDoTitleDal = toDoTitleDal;
            _userDal = userDal;
        }
        public IResult Add(ToDoTitleDto model)
        {
            var toDoTitle = _mapper.Map<ToDoTitle>(model);
            toDoTitle.AddedDate = DateTime.Now;
            _toDoTitleDal.Add(toDoTitle);
            return new SuccessResult();
        }

        public IResult Delete(ToDoTitleDto model)
        {
            var entity = _mapper.Map<ToDoTitle>(model);
            _toDoTitleDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<ToDoTitleDto> Get(Expression<Func<ToDoTitle, bool>> filter = null)
        {
            var dto = _mapper.Map<ToDoTitleDto>(_toDoTitleDal.Get(filter));
            return new SuccessDataResult<ToDoTitleDto>(dto);
        }

        public IDataResult<List<ToDoTitleDto>> GetList(Expression<Func<ToDoTitle, bool>> filter = null)
        {

            var dtoList = _mapper.Map<List<ToDoTitleDto>>(_toDoTitleDal.GetList(filter).ToList());
            return new SuccessDataResult<List<ToDoTitleDto>>(dtoList);
           
        }

        public IResult Update(ToDoTitleDto model)
        {
            var entity = _mapper.Map<ToDoTitle>(model);
            _toDoTitleDal.Update(entity);
            return new SuccessResult();
        }
    }
}
