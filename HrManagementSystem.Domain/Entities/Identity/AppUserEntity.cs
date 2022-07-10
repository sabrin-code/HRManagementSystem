using HrManagementSystem.Persistence.Interfaces.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities.Identity
{
    public class AppUserEntity : IdentityUser<int>,IBaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual EmployeeEntity Employee  { get; set; }
        public DateTime CreateDate { get; set ; }
        public string Description { get ; set ; }
        public bool IsDeleted { get; set ; }
    }
}