using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTracking.Core.Data;

namespace BusTracking.Core.IRepository
{
    public interface ISearchChildrenRepository
    {
        public Task <List<Child>> SearchChildrenByName(string name);
    }
}
