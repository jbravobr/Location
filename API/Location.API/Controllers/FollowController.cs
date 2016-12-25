using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Location.API.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Location.API.Controllers
{
    [Route("api/[controller]")]
    public class FollowController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            return Json(new List<Follow>());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Json(new Follow());
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody]Follow user)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Follow user)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
        }
    }
}
