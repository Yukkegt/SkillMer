using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMer.Shared.Entities;
public class CommonEntity
{
    [Column(Order = 97)]
    public bool DeleteFlg { get; set; }

    [Column(Order = 98)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreateAt { get; set; }

    [Column(Order = 99)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? UpdateAt { get; set; }

}

public class MUser : CommonEntity
{
    [Key]
    [Column(Order = 1, TypeName = "varchar(15)")]
    public string UserId { get; set; }

    [Column(Order = 2, TypeName = "varchar(50)")]
    public string Name { get; set; }
    public List<TUsersSkill> Skills { get; set; }
    public List<TUsersJob> Jobs { get; set; }
}

public class MSkill : CommonEntity
{
    [Key]
    [Column(Order = 1)]
    public int SkillId { get; set; }

    [Column(Order = 2)]
    public string Category { get; set; }

    [Column(Order = 3)]
    public string SkillName { get; set; }
    public List<TUsersSkill> Users { get; set; }

}

public class MJob : CommonEntity
{
    [Key]
    [Column(Order = 1)]
    public int JobId { get; set; }
    [Column(Order = 2)]
    public string Category { get; set; }
    [Column(Order = 3)]
    public string Name { get; set; }
    public List<TUsersJob> Users { get; set; }


}

public class TUsersSkill : CommonEntity
{
    /// <summary>
    /// ユーザーID
    /// </summary>
    [Column(Order = 1)]
    public string UserId { get; set; }

    /// <summary>
    /// ユーザーID
    /// </summary>
    [Column(Order = 2)]
    public int SkillId { get; set; }

    public MUser User { get; set; }

    public MSkill Skill { get; set; }
}

public class TUsersJob : CommonEntity
{
    /// <summary>
    /// ユーザーID
    /// </summary>
    [Column(Order = 1)]
    public string UserId { get; set; }

    /// <summary>
    /// 肩書ID
    /// </summary>
    [Column(Order = 2)]
    public int JobId { get; set; }
    public MUser User { get; set; }

    public MJob Job { get; set; }
}
