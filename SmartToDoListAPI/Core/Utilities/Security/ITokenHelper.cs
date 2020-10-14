using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Core.Utilities.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserDto user);//, List<OperationClaim> operationClaims
    }
}
