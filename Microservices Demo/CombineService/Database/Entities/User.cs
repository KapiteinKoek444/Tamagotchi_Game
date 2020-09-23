using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Shared;

namespace UserService.Database.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
