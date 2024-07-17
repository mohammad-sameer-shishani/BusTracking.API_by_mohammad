using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;
using BusTracking.Core.IRepository;
using BusTracking.Core.IService;

namespace BusTracking.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.CreateUser(user);
        }

        public async Task DeleteUser(int userid)
        {
            await _userRepository.DeleteUser(userid);
        }

        public async Task<List<User>> GetAllUser()
        {
            return await _userRepository.GetAllUser();
        }

        public async Task<List<User>> GetAllTeachers()
        {
            var result=await _userRepository.GetAllUser();
            var result2= result.Where(x=>x.Roleid==2);
            return result2.ToList();
        }

        public async Task<List<User>> GetAllDrivers()
        {
            var result = await _userRepository.GetAllUser();
            var result2 = result.Where(x => x.Roleid == 5);
            return result2.ToList();
        }

        public async Task<List<User>> GetAllParents()
        {
            var result = await _userRepository.GetAllUser();
            var result2 = result.Where(x => x.Roleid == 3);
            return result2.ToList();
        }



        public async Task<User> GetUserById(int userid)
        {
            return await _userRepository.GetUserById(userid);
        }

        public async Task UpdateUser(User user)
        {
            await _userRepository.UpdateUser(user);
        }
    }
}
