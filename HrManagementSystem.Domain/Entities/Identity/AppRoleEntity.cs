using HrManagementSystem.Persistence.Interfaces.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities.Identity
{
    public class AppRoleEntity : IdentityRole<int>, IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
