using HrManagementSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities
{
    [Table("VacationDays")]
    public class VacationDaysEntity:BaseEntity
    {
        public int CountOfDay { get; set; }
        public int PositionId { get; set; }

        [ForeignKey(nameof(PositionId))]
        public virtual PositionEntity Position { get; set; }
    }
}
