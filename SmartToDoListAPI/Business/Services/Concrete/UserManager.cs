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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;

        }
        public IResult Add(UserDto model)
        {
            var user = _mapper.Map<User>(model);
            user.AddedDate = DateTime.Now;
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(UserDto model)
        {
            var user = _mapper.Map<User>(model);
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<UserDto> Get(Expression<Func<User, bool>> filter = null)
        {
            var dto = _mapper.Map<UserDto>(_userDal.Get(filter));
            return new SuccessDataResult<UserDto>(dto);
        }

        public IDataResult<UserDto> GetByMail(string email)
        {
            var user = _userDal.Get(c => c.Email == email);

            if (user!=null)
            {
                var userDto = _mapper.Map<UserDto>(user);
                return new SuccessDataResult<UserDto>(userDto);
            }

            else
            {
                return new ErrorDataResult<UserDto>();
            }
        }

        public IDataResult<List<UserDto>> GetList(Expression<Func<User, bool>> filter = null)
        {
            var dtoList = _mapper.Map<List<UserDto>>(_userDal.GetList(filter));
            return new SuccessDataResult<List<UserDto>>(dtoList);
        }

        public IResult Update(UserDto model)
        {
            var entity = _mapper.Map<User>(model);
            _userDal.Update(entity);
            return new SuccessResult();
        }
    }
}
