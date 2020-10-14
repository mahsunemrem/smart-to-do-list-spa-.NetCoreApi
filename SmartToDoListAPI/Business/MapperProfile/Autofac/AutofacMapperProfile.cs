using AutoMapper;
using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.AutoMapperProfile.Autofac
{
    public class AutofacMapperProfile : Profile
    {
        public AutofacMapperProfile()
        {
            CreateMap<ToDoTitle, ToDoTitleDto>();
            CreateMap<ToDoTitleDto, ToDoTitle>();

            CreateMap<ToDoItem, ToDoItemDto>();
            CreateMap<ToDoItemDto, ToDoItem>();

            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
