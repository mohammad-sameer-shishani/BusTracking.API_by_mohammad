using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;
using BusTracking.Core.ICommon;
using BusTracking.Core.IRepository;
using Dapper;

namespace BusTracking.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContext _dBContext;
        public UserRepository(IDbContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task CreateUser(User user)
        {
            var param = new DynamicParameters();
            param.Add("c_firstname", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_lastname", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_address", user.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_imagepath", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_phone", user.Phone, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("c_roleid", user.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("c_gender", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            await _dBContext.Connection.ExecuteAsync("user__package.create_user_", param, commandType: CommandType.StoredProcedure);

        }

        public async Task DeleteUser(int userid)
        {
            var param = new DynamicParameters();
            param.Add("d_userID", userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            await _dBContext.Connection.ExecuteAsync("user__package.delete_user_", param, commandType: CommandType.StoredProcedure);

        }

        public async Task<List<User>> GetAllUser()
        {
            var result = await _dBContext.Connection.QueryAsync<User>("user__package.get_all_user_", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public async Task<User> GetUserById(int id)
        {
            var param = new DynamicParameters();
            param.Add("d_userID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<User>("user__package.get_user__by_id", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public async Task UpdateUser(User user)
        {
            var param = new DynamicParameters();
            param.Add("u_userID", user.Userid, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_firstname", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_lastname", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_address", user.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_imagepath", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("c_phone", user.Phone, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("c_roleid", user.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("c_gender", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            await _dBContext.Connection.ExecuteAsync("user__package.update_user_", param, commandType: CommandType.StoredProcedure);

        }
    }
}
