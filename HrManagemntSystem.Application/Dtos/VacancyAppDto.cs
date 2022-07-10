using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Dtos
{
    public class VacancyAppDto
    {
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public int Count { get; set; }
        public int EmployeeId { get; set; }
    }
}
