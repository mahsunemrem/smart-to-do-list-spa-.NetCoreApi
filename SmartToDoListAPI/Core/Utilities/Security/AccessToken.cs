using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Core.Utilities.Security
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
