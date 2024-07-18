using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;

namespace BusTracking.Core.IRepository
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllRole();
        Task<Role> GetRoleById(int roleid);
        Task CreateRole(Role role);
        Task UpdateRole(Role role);
        Task DeleteRole(int roleid);

    }
}
