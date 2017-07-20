using FlatPlanet.Data.Context;
using FlatPlanet.Data.Models;
using FlatPlanet.Service.Interfaces;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.Service.Concrete
{
    public class CounterService : ICounterService
    {
        private FlatPlanetContext _context;

        public CounterService()
        {
            if (_context == null)
            {
                _context = new FlatPlanetContext();
            }
        }

        public int GetLatestCount()
        {
            var result = _context.Set<Counter>().AsExpandable().Count();
            return result;
        }

        public int IncreaseCount(int count)
        {
            _context.Set<Counter>().Add(new Counter() { Id = count });
            _context.SaveChanges();

            return this.GetLatestCount();
        }
    }
}
