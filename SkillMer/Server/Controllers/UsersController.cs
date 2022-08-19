using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillMa.EntityFramework;
using SkillMer.Shared.Entities;
using System;

namespace SkillMer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
{
        private readonly SkillMerDbContext context;

        public UsersController(SkillMerDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 全ユーザーリストを取得する
        /// </summary>
        /// <returns>全てのユーザーのJSONデータ</returns>
        [HttpGet]
        public ActionResult<IEnumerable<MUser>> Get()
        {
            foreach(var user in context.Users)
            {
                user.Skills = context.UsersSkill.Where(x => x.UserId == user.UserId).ToList();
                foreach(var skill in user.Skills)
                {
                    skill.Skill = context.Skills.Find(skill.SkillId);
                }
            }
            return context.Users;
        }

        /// <summary>
        /// 特定のユーザーIDを持つユーザーを取得する
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>ユーザーIDが一致したユーザーのJSONデータ</returns>
        [HttpGet("{id}")]
        public ActionResult<MUser> Get(string id)
        {
            MUser user = context.Users.Find(id);

            user.Skills = context.UsersSkill.Where(x => x.UserId == user.UserId).ToList();
            foreach (var skill in user.Skills)
            {
                skill.Skill = context.Skills.Find(skill.SkillId);
            }
            return user;
        }

        [HttpPost]
        public void Post()
        {

        }
    }
}
