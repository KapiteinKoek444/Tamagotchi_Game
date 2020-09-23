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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private MongoCRUD db;
        public UserController()
        {
            db = new MongoCRUD("Users");
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.LoadRecords<User>("UserData");
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return db.LoadRecordById<User>("UserData",id);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                db.InsertRecord("UserData", model);

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


    }
}
