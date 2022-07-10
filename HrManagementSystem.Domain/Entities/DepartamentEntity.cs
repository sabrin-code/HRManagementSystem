using HrManagementSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Domain.Entities
{
    [Table("Departament")]
    public class DepartamentEntity:BaseEntity
    {

        public string Name { get; set; }
        public string ShortName { get; set; }

    }
}
