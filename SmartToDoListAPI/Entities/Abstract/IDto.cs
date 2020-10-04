using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Abstract
{
    public interface IDto
    {
        public Guid Id { get; set; }
    }
}
