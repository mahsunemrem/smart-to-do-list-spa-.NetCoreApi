using SmartToDoListAPI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Concrete
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime AddedDate { get ; set; }
        public int isDelete { get ; set ; }
    }
}
