using BusTracking.Core.Data;
using BusTracking.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTracking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildrenController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]               //succesfully working
        public async Task<List<Child>> GetAllChildren()
        {
            return await _childService.GetAllChildren();
        }

        [HttpPost]             //succesfully working
        public async Task CreateChild(Child child)
        {
            await _childService.CreateChild(child);
        }


        [HttpGet("{id}")]      //succesfully working
        public async Task<Child>GetChildById(int id) 
        {
            return await _childService.GetChildById(id);
        }
        
        [HttpDelete("{id}")]  //succesfully working
        public async Task DeleteChild(int id) 
        {
            await _childService.DeleteChild(id);
        }
        
        
        [HttpPut]             //succesfully working
        public async Task UpdateChild([FromBody]Child child) 
        {
        await _childService.UpdateChild(child);
        }

    }
}
