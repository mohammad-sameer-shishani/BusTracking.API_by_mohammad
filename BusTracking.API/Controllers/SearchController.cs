using BusTracking.Core.Data;
using BusTracking.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTracking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchChildrenService _searchChildrenService;

        public SearchController(ISearchChildrenService searchChildrenService)
        {
            _searchChildrenService = searchChildrenService;
        }

        [HttpGet("{name}")]                //successfully working
        public Task<List<Child>> SearchChildrenByName(string name) 
        {
              return _searchChildrenService.SearchChildrenByName(name);
        }
    }
}
