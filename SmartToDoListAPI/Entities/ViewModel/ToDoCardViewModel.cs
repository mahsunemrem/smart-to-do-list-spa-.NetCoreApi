using SmartToDoListAPI.Entities.Concrete;
using SmartToDoListAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.ViewModel
{
    public class ToDoCardViewModel
    {
        public ToDoTitleDto ToDoTitle { get; set; }
        public List<ToDoItemDto> ToDoItem { get; set; }
    }
}
