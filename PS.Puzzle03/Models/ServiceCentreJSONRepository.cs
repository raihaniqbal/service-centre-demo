using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PS.Puzzle03.Models
{
    public class ServiceCentreJSONRepository : IRepository<ServiceCentre>
    {
        public IEnumerable<ServiceCentre> List
        {
            get
            {
                string path = String.Format(@"{0}\Data\serviceCentres.json", Environment.CurrentDirectory);
                return JsonConvert.DeserializeObject<IEnumerable<ServiceCentre>>(File.ReadAllText(path));
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