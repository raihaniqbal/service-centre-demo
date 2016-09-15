using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PS.Puzzle03.Models;
using System.Web;

namespace PS.ServiceCentre.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void TestInit()
        {
            // TO DO: Set up fake HttpContext for PhysicalApplicationPath to work

        }

        [TestMethod]
        public void TestMethod1()
        {
            ServiceCentreJSONRepository repo = new ServiceCentreJSONRepository();
            Assert.IsNotNull(repo.List);
        }
    }
}
