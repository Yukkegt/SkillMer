using Microsoft.AspNetCore.Mvc;
using SkillMa.EntityFramework;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillMer.Server.Controllers
{
    [Route("api/user/[controller]")]
    [ApiController]
    public class UsersInfoController : ControllerBase
    {
        private readonly SkillMerDbContext context;

        public UsersInfoController(SkillMerDbContext context)
        {
            this.context = context;
        }

        // GET: api/user/<UsersInfoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersInfoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersInfoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
