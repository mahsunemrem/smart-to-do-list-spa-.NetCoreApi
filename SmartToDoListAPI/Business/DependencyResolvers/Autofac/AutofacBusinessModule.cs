using Autofac;
using SmartToDoListAPI.Business.Services.Abstract;
using SmartToDoListAPI.Business.Services.Concrete;
using SmartToDoListAPI.DataAccess.Abstract;
using SmartToDoListAPI.DataAccess.Concrete.EntityFramework;
using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<EfToDoTitle>().As<IToDoTitleDal>();
            builder.RegisterType<ToDoTitleManager>().As<IToDoTitleService>();

            builder.RegisterType<EfToDoItem>().As<IToDoItemDal>();
            builder.RegisterType<ToDoItemManager>().As<IToDoItemService>();

            builder.RegisterType<EfUser>().As<IUserDal>();

        }

    }
}
