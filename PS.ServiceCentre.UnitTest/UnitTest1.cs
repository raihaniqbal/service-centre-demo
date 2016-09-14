using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PS.Puzzle03.Models;

namespace PS.ServiceCentre.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceCentreJSONRepository repo = new ServiceCentreJSONRepository();
            Assert.IsNotNull(repo.List);
        }
    }
}
