using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using SimpleApiReturnTenisPlaysStats.Models.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Contracts;
using SimpleApiReturnTenisPlaysStats.Repository.Implementations;
using SimpleApiReturnTenisPlaysStats.Repository.Moqs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApiReturnTenisPlaysStats.UnitTests
{
    [TestClass]
    public class TenisPlaysStatsRepositoryTests
    {
        #region -- Properties --

        Mock<TenisPlayerObject> _tenisPlayerObjectMock = new Mock<TenisPlayerObject>();
        private TenisPlaysStatsRepositoryMock tenisPlaysStatsRepositoryMock = null;
        private TenisPlaysStatsRepository _tenisPlaysStatsRepository = null;
        #endregion

        #region -- Constructor -- 
        public TenisPlaysStatsRepositoryTests()
        {

        }
        #endregion

        #region -- Methods --
        [SetUp]
        public void SetUp()
        {
           
        }

        [TearDown]
        public void TearDown()
        {

        }

        [TestMethod]
        public void GetTenisPlayes_ShouldPass_ReturAllTenisPlayer()
        {
            tenisPlaysStatsRepositoryMock = new TenisPlaysStatsRepositoryMock();
            _tenisPlaysStatsRepository = new TenisPlaysStatsRepository();

            var mockTenis = tenisPlaysStatsRepositoryMock.GetPlayers(); 

            var commingTenis = _tenisPlaysStatsRepository.GetPlayers();
            
            NUnit.Framework.Assert.AreEqual(mockTenis.Count(), commingTenis.Count());
        }

        [TestMethod]
        public void GetPlayerById_GivingUnknownId_ShouldSend404Message()
        {
           
        }

        [TestMethod]
        public void GetPlayerById_GivingknownId_ShouldSendWork()
        {
          
        }

        [TestMethod]
        public void Delete_GivingknownId_ShouldSendWork()
        {
           
        }

        #endregion
    }
}
