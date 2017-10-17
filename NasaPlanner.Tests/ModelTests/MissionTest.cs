using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaPlanner.Models;

namespace NasaPlanner.Tests
{
    [TestClass]
    public class MissionTest
    {
        [TestMethod]
        public void GetAstronauts()
        {
            var newMission = new Mission(1, 100);

            var result = newMission.GetAstronauts();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetMultiAstronauts()
        {
            var newMission = new Mission(3, 1200);

            var result = newMission.GetAstronauts();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetTriAstronauts()
        {
            var newMission = new Mission(5, 2500);

            var result = newMission.GetAstronauts();

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetLottaAstronauts()
        {
            var newMission = new Mission(2, 9000);

            var result = newMission.GetAstronauts();

            Assert.AreEqual(22, result);
        }
    }
}
