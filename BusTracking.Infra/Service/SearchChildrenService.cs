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
    public class SearchChildrenService : ISearchChildrenService
    {
        private readonly ISearchChildrenRepository _searchChildrenRepository;

        public SearchChildrenService(ISearchChildrenRepository searchChildrenRepository)
        {
            _searchChildrenRepository = searchChildrenRepository;
        }

        public Task<List<Child>> SearchChildrenByName(string name)
        {
            return _searchChildrenRepository.SearchChildrenByName(name);
        }
    }
}
