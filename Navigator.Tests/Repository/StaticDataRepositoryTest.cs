using System.Collections.Generic;
using System.Linq;
using EVEStandard.Enumerations;
using EVEStandard.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Navigator.Consts;
using Navigator.Interfaces;
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
            var mockCache = new Mock<IUniverseCache>();
            mockCache.Setup(x => x.GetAllByCategory(It.IsAny<CategoryEnum>())).Returns(Systems());

            _staticDataRepo = new StaticDataRepository(mockCache.Object);
        }

        private static IEnumerable<UniverseIdsToNames> Systems()
        {
            return new List<UniverseIdsToNames>
            {
                new UniverseIdsToNames {Category = CategoryEnum.solar_system, Id = int.Parse(SolarSystemId.Jita), Name = "Jita"},
                new UniverseIdsToNames {Category = CategoryEnum.solar_system, Id = 1, Name = "J130719"},
                new UniverseIdsToNames {Category = CategoryEnum.solar_system, Id = 1, Name = "J230559"},
                new UniverseIdsToNames {Category = CategoryEnum.solar_system, Id = 1, Name = "Thera"},
                new UniverseIdsToNames {Category = CategoryEnum.solar_system, Id = 1, Name = "Amarr"}
            };
        }

        [TestMethod]
        public void OnlyGetKSpaceSystems()
        {
            Assert.AreEqual(2, _staticDataRepo.GetAllSystems().Count());
        }
    }
}