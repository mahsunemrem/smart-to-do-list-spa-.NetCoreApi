using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Concrete
{
    public class ToDoTitle : Entity
    {
        public string Title { get; set; }
        public string Color { get; set; }
        [Required]
        public Guid UserId { get; set; }



    }
}
