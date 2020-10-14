using AutoMapper;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using SmartToDoListAPI.Business.Services.Abstract;
using SmartToDoListAPI.Core.Utilities.Security;
using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.Services.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private IMapper _mapper;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, IMapper mapper, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
        }
        public IResult AddUserRole(Guid userId, string roleName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(UserDto userDto)
        {
            //var claims = _userService.GetClaims(jwtUserModel.Id).Data;
            var accessToken = _tokenHelper.CreateToken(userDto);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        public IDataResult<UserDto> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email).Data;
            if (userToCheck == null)
            {
                return new ErrorDataResult<UserDto>();
            }
          
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<UserDto>();
            }

            return new SuccessDataResult<UserDto>(userToCheck);
        }

        public IDataResult<UserDto> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var userDto = new UserDto
            {
                Id = userForRegisterDto.Id,
                Email = userForRegisterDto.Email,
                Name = userForRegisterDto.Name,
                Surname = userForRegisterDto.Surname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            var result = _userService.Add(userDto);
           
            return new SuccessDataResult<UserDto>(userDto);
        }

        public IDataResult<UserDto> UpdateUser(UserForRegisterDto userForRegisterDto, string password = null)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
