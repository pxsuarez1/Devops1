using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Devops.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevopsController : ControllerBase
    {
        // GET: api/<DevopsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DevopsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DevopsController>
        [HttpPost]
        public IEnumerable<string> Post()
        {
           
            return new string[] { "message", "Hello Juan Perez your message will be send.." };
        }

       
    }
}
