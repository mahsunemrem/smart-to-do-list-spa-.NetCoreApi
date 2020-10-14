using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartToDoListAPI.Business.Services.Abstract;
using SmartToDoListAPI.Entities.Dtos;

namespace SmartToDoListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;
        private IAuthService _authService;
        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto model)
        {
            if (_userService.GetList().Data.Count<1)
            {
                _authService.Register(new UserForRegisterDto() { Id = Guid.NewGuid(), Surname = "emrem", Name = "mahsun", Email = "mahsunemrem@gmail.com", Password = "123" });
            }
            if (_userService.GetList().Data.Count < 2)
            {
                _authService.Register(new UserForRegisterDto() { Id = Guid.NewGuid(), Surname = "emrem", Name = "mahsun", Email = "mahsunemrem2@gmail.com", Password = "123" });
            }
            var userToLogin = _authService.Login(model);
            if (!userToLogin.Success)
            {
                return NotFound();
            }

            var token = _authService.CreateAccessToken(userToLogin.Data).Data;
         
            return Ok(token);
           
        }

    }
}
