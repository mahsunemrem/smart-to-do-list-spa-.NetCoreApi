using Core.Utilities.Results;
using SmartToDoListAPI.Core.Utilities.Security;
using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.Services.Abstract
{
    public interface IAuthService
    {
        IDataResult<UserDto> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<UserDto> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(UserDto userDto);

        IDataResult<UserDto> UpdateUser(UserForRegisterDto userForRegisterDto, string password = null);
        IResult AddUserRole(Guid userId, string roleName);
    }
}
