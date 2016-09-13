using System;
using System.Collections.Generic;
using System.Web.Http;
using PS.Puzzle03.Domain;
using PS.Puzzle03.Models;

namespace PS.Puzzle03.Controllers
{
    public class ServiceCentresController : ApiController
    {
        private readonly IServiceCentreService _serviceCentreService;

        public ServiceCentresController(IServiceCentreService serviceCentreService)
        {
            _serviceCentreService = serviceCentreService;
        }

        [Route("api/servicecentres/getnearby")]
        [HttpGet]
        public IEnumerable<ServiceCentre> GetNearby(double latitude, double longitude)
        {
           throw new NotImplementedException();
        }
    }
}
