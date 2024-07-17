using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;

namespace BusTracking.Core.IService
{
    public interface IChildService
    {
        Task<List<Child>> GetAllChildren();
        Task<Child> GetChildById(int id);
        Task CreateChild(Child child);
        Task UpdateChild(Child child);
        Task DeleteChild(int id);
    }
}
