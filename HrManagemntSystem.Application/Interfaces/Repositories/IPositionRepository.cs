using HrManagementSystem.Domain.Entities;
using HrManagemntSystem.Application.Interfaces.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Repositories
{
    public interface IPositionRepository : ICRUDRepository<PositionEntity>
    {

    }
    
}
