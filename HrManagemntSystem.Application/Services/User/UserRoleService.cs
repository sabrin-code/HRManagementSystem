using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Services.Base;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using HrManagemntSystem.Application.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Services.User
{
    public class UserRoleService : BaseService<AppUserRoleEntity>, IUserRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<bool> SaveRoleToUser(int userId, int[] roleid)
        {
            try
            {
                var userRoles = GetAll().Where(x => x.UserId == userId && !x.IsDeleted)
                 .Select(x => new AppUserRoleEntity { Id = x.Id, RoleId = x.RoleId, UserId = x.UserId }).ToList();

                var oldRoleIds = userRoles.Select(t => t.RoleId).ToList();
                var removeRoleIds = oldRoleIds.Except(roleid).ToList();
                var addRoleIds = roleid.Except(oldRoleIds).ToList();

                if (removeRoleIds.Count() > 0)
                {
                    RemoveRange(userRoles.Where(t => removeRoleIds.Contains(t.RoleId)).ToList());
                }
                if (addRoleIds.Count() > 0)
                {
                    var userRoleEntity = new List<AppUserRoleEntity>();
                    addRoleIds
                    .ForEach(x => userRoleEntity.Add(new AppUserRoleEntity { RoleId = x, UserId = userId }));
                    await AddRangeAsync(userRoleEntity);
                    _unitOfWork.Commit();
                }
            }
            catch
            {
                return false;


            }
            return true;

        }
    }
}