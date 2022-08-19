using Microsoft.AspNetCore.Mvc;
using SkillMa.EntityFramework;
using SkillMer.Shared.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillMer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly SkillMerDbContext context;

        public SkillsController(SkillMerDbContext context)
        {
            this.context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<MSkill>> Get()
        {
            foreach (var skill in context.Skills)
            {
                skill.Users = context.UsersSkill.Where(x => x.SkillId == skill.SkillId).ToList();
                foreach (var user in skill.Users)
                {
                    user.User = context.Users.Find(user.UserId);
                }
            }
            return context.Skills;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{skillId}")]
        public ActionResult<MSkill> GetSkill(string skillId) => context.Skills.Find(skillId);

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
