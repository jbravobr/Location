using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Location.API.Model;

namespace Location.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(new List<User>());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Json(new User());
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody]User user)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]User user)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
        }
    }
}
