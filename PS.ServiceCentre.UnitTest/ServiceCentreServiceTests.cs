using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PS.Puzzle03.Models;
using System.Web;
using PS.Puzzle03.Domain;
using PS.UnitTest.Mocks;

namespace PS.UnitTest.Tests
{
    [TestClass]
    public class ServiceCentreServiceTests
    {
        IServiceCentreService _service;

        [TestInitialize]
        public void TestInit()
        {
            _service = new ServiceCentreService(new MockRepository());
        }

        [TestMethod]
        public void Can_Get_Nearby_Service_Centres()
        {
            Assert.IsNotNull(_service.GetNearby(new MapLocation() { }));
        }
    }
}
