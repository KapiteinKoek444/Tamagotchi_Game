using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.MongoDB;
using UserService.Database;
using UserService.Database.Entities;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetAnimalController : ControllerBase
    {
        private MongoCRUD db;
        public PetAnimalController()
        {
            db = new MongoCRUD("PetAnimals");
        }

        // GET: api/<PetAnimalController>
        [HttpGet]
        public IEnumerable<PetAnimal> Get()
        {
            return db.LoadRecords<PetAnimal>("Animals");
        }

        // GET api/<PetAnimalController>/5
        [HttpGet("{id}")]
        public PetAnimal Get(Guid id)
        {
            return db.LoadRecordById<PetAnimal>("Animals", id);
        }

        // POST api/<PetAnimalController>
        [HttpPost]
        public IActionResult Post([FromBody] PetAnimal model)
        {
            try
            {
                db.InsertRecord("Animals", model);

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }

}
