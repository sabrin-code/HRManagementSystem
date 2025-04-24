using HrManagementSystem.Persistence.Interfaces.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities.Identity
{
    public class AppUserRoleEntity: IdentityUserRole<int>, IBaseEntity
    {
       
        public DateTime CreateDate { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
