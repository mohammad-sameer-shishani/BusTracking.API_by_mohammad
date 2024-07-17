using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;

namespace BusTracking.Core.IService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUser();
        Task<List<User>> GetAllTeachers();
        Task<List<User>> GetAllDrivers();
        Task<List<User>> GetAllParents();
        Task<User> GetUserById(int id);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int userid);
    }
}
