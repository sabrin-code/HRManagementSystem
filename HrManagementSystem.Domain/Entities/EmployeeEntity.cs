using HrManagementSystem.Domain.Entities.Common;
using HrManagementSystem.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities
{
    [Table("Employee")]
    public class EmployeeEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int PositionId { get; set; }
        public int DepartamentId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public virtual PositionEntity Position { get; set; }
        [ForeignKey(nameof(DepartamentId))]
        public virtual DepartamentEntity Departament { get; set; }
       
    }
}
