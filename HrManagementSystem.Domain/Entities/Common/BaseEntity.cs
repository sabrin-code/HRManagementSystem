using HrManagementSystem.Persistence.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities.Common
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [Required]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("CreateDate")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; } = false;
        //[ForeignKey("CreateUserId")]
        //public virtual UserEntity CreateUser { get; set; }
    }
}
