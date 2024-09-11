﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        // GET: api/<VenueController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VenueController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VenueController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VenueController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VenueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
