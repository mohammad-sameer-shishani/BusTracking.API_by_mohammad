using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;
using BusTracking.Core.DTO;

namespace BusTracking.Core.IRepository
{
    public interface IUserRepository
    {
        Task<List<UserResult>> GetAllUser();
        Task<User> GetUserById(int userid);
        Task CreateUser(User user);
        Task UpdateUser(User user);

        Task DeleteUser(int userid);
    }
}
