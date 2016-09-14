using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PS.Puzzle03.Models;
using System.Data.Spatial;

namespace PS.Puzzle03.Domain
{
    public class ServiceCentreService : IServiceCentreService
    {
        IRepository<ServiceCentre> _serviceCentreRepo;
        public ServiceCentreService(IRepository<ServiceCentre> serviceCentreRepo)
        {
            _serviceCentreRepo = serviceCentreRepo;
        }

        public IEnumerable<ServiceCentre> GetNearby(MapLocation mapLocation)
        {
            var userLocation = DbGeography.FromText(String.Format("POINT({1} {0})", mapLocation.Latitude, mapLocation.Longitude));

            var serviceCentres = _serviceCentreRepo.List.OrderBy(s => DbGeography.FromText(String.Format("POINT({1} {0})", s.Latitude, s.Longitude)).Distance(userLocation)).Take(4);

            return serviceCentres;
        }
    }
}