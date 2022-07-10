using HrManagementSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities.Identity
{
    [Table("Status")]
    public class StatusEntity:BaseEntity
    {
        public string Name { get; set; }
        public string StatusKey { get; set; }
    }
}
