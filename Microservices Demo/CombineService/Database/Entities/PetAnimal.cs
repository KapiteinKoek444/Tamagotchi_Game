using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Shared;

namespace UserService.Database.Entities
{
    public class PetAnimal : EntityBase
    {

        public Guid UserId { get; set; }
        public string Name { get; set; }

        public float Food { get; set; }

        public float Energy { get; set; }

        public float happiness { get; set; }



    }
}
