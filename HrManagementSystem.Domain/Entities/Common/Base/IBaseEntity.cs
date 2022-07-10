using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Interfaces.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreateDate { get; set; }
        string Description { get; set; }
        bool IsDeleted { get; set; }
    }
}
