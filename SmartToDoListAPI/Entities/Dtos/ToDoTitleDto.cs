using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Dtos
{
    public class ToDoTitleDto : Dto
    {
        public string Title { get; set; }
        public string Color { get; set; }

        public Guid UserId { get; set; }

    }
}
