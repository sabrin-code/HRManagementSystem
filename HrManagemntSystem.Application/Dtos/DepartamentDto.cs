using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Dtos
{
    public class DepartamentDto
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
    }
}
