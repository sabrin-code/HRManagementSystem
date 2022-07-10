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
    [Table("VacationApplication")]
    public class VacationApplicationEntity:BaseEntity
    {
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public int Count { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(StatusId))]
        public virtual StatusEntity Status { get; set; }
        [ForeignKey(nameof(EmployeeId))]    
        public virtual EmployeeEntity Employee { get; set; }
    }
}
