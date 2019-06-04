using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Navigator.Consts;
using Navigator.DAL;
using Navigator.DAL.SDE;
using Navigator.Repositories;

namespace Navigator.Tests.Repository
{
    [TestClass]
    [TestCategory("Repository")]
    public class StaticDataRepositoryTest
    {
        private static StaticDataRepository _staticDataRepo;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var mockDbContext = new Mock<TranquilityContext>(MockBehavior.Default);
            mockDbContext.Setup(x => x.MapSolarSystems).ReturnsDbSet(Systems());

            var mockServiceProvider = new Mock<IServiceProvider>();
            mockServiceProvider.Setup(x => x.GetService(typeof(TranquilityContext))).Returns(mockDbContext.Object);

            _staticDataRepo = new StaticDataRepository(mockServiceProvider.Object);
        }

        private static MapSolarSystems[] Systems()
        {
            return new MapSolarSystems[]
            {
                new MapSolarSystems {SolarSystemId = int.Parse(SolarSystemId.Jita), SolarSystemName = "Jita"},
                new MapSolarSystems {SolarSystemId = 2, SolarSystemName = "J130719"},
                new MapSolarSystems {SolarSystemId = 3, SolarSystemName = "J230559"},
                new MapSolarSystems {SolarSystemId = 4, SolarSystemName = "Thera"},
                new MapSolarSystems {SolarSystemId = 5, SolarSystemName = "Amarr"}
            };
        }
        
        [TestMethod]
        public void OnlyGetKSpaceSystems()
        {
            Assert.AreEqual(2, _staticDataRepo.GetAllSystems().Count());
        }
    }
}