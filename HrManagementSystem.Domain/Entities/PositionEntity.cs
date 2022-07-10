using HrManagementSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities
{
    [Table("Position")]
    public class PositionEntity:BaseEntity
    {
        public string Name { get; set; }
    }
}
