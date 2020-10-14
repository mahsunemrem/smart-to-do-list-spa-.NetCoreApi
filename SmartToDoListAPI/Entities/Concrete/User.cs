using SmartToDoListAPI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Concrete
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

    }
}
