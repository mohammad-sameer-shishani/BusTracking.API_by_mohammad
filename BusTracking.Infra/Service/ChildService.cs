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
    public class ChildService : IChildService
    {
        private readonly IChildRepository _childRepository;

        public ChildService(IChildRepository childRepository)
        {
            _childRepository = childRepository;
        }

        public async Task CreateChild(Child child)
        {
             await _childRepository.CreateChild(child);
        }

        public async Task DeleteChild(int id)
        {
            await _childRepository.DeleteChild(id);
        }

        public Task<List<Child>> GetAllChildren()
        {
            return _childRepository.GetAllChildren();
        }

        public Task<Child> GetChildById(int id)
        {
            return _childRepository.GetChildById(id);
        }

        public async Task UpdateChild(Child child)
        {
            await _childRepository.UpdateChild(child);
        }
    }
}
