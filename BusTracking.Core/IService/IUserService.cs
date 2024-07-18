using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;
using BusTracking.Core.DTO;

namespace BusTracking.Core.IService
{
    public interface IUserService
    {
        Task<List<UserResult>> GetAllUser();
        Task<List<UserResult>> GetAllTeachers();
        Task<List<UserResult>> GetAllDrivers();
        Task<List<UserResult>> GetAllParents();
        Task<User> GetUserById(int id);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int userid);
    }
}
