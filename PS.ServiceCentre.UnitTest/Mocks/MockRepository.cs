using PS.Puzzle03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.UnitTest.Mocks
{
    public class MockRepository : IRepository<ServiceCentre>
    {
        public IEnumerable<ServiceCentre> List
        {
            get
            {
                return new List<ServiceCentre>();
            }
        }

        public void Add(ServiceCentre entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ServiceCentre entity)
        {
            throw new NotImplementedException();
        }

        public ServiceCentre FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(ServiceCentre entity)
        {
            throw new NotImplementedException();
        }
    }
}
