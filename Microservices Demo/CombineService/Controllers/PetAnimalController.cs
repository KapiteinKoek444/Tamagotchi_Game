using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Database;
using UserService.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetAnimalController : ControllerBase
    {
        private DatabaseContext db;
        public PetAnimalController()
        {
            db = new DatabaseContext();
        }

        // GET: api/<PetAnimalController>
        [HttpGet]
        public IEnumerable<PetAnimal> Get()
        {
            return db.PetAnimals.ToList();
        }

        // GET api/<PetAnimalController>/5
        [HttpGet("{id}")]
        public PetAnimal Get(Guid id)
        {
            return db.PetAnimals.Find(id);
        }

        // POST api/<PetAnimalController>
        [HttpPost]
        public IActionResult Post([FromBody] PetAnimal model)
        {
            try
            {
                db.PetAnimals.Add(model);
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }

}
