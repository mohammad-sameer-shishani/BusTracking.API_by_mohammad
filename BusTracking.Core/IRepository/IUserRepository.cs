using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;

namespace BusTracking.Core.IRepository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Task<User> GetUserById(int userid);
        Task CreateUser(User user);
        Task UpdateUser(User user);

        Task DeleteUser(int userid);
    }
}
