using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Dtos
{
    public class ToDoItemDto : Dto
    {
        public string Name { get; set; }
        public bool isDone { get; set; }

        [Required]
        public Guid ToDoTitleId { get; set; }
        [ForeignKey("ToDoTitleId")]
        public virtual ToDoTitle ToDoTitle { get; set; }
    }
}
