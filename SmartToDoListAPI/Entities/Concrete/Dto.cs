using SmartToDoListAPI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Concrete
{
    public class Dto : IDto
    {
        public Guid Id { get; set ; }
    }
}
