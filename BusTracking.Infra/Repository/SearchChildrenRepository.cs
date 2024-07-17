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
    public class SearchChildrenRepository: ISearchChildrenRepository
    {
        private readonly IDbContext _dbContext;

        public SearchChildrenRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Child>> SearchChildrenByName(string name)
        {
            var param = new DynamicParameters();
            param.Add("search_Name", name,dbType:DbType.String,direction:ParameterDirection.Input);    
            var result =await _dbContext.Connection.QueryAsync<Child>("Search_Children_Package.Search_Children_By_Name",param,commandType:CommandType.StoredProcedure);
            return result.ToList();        
        }
    }
}
