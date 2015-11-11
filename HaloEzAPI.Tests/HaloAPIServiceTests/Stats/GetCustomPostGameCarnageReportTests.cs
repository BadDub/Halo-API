using System;
using System.Linq;
using NUnit.Framework;

namespace HaloEzAPI.Tests.HaloAPIServiceTests.Stats
{
    [TestFixture]
    public class GetCustomPostGameCarnageReportTests : BaseHaloAPIServiceTests
    {
        private static readonly Guid _validGuid = new Guid("8ea876a1-12d2-4942-89b2-cb539efc0a21");

        [Test]
        public void Default_DoesNotThrowException()
        {
            Assert.DoesNotThrow(async () => await HaloApiService.GetCustomPostGameCarnageReport(_validGuid));
        }

        [Test]
        public async void Default_DoesNotReturnNull()
        {
            var result = await HaloApiService.GetCustomPostGameCarnageReport(_validGuid);
            Assert.IsNotNull(result);
        }

        [Test]
        [TestCase("Glitch100")]
        [TestCase("Swainoo")]
        public async void ProvideValidMatchId_ReturnsKnownPlayer(string gamerTag)
        {
            var result = await HaloApiService.GetCustomPostGameCarnageReport(_validGuid);
            Assert.IsTrue(result.PlayerStats.Any(ps => ps.Player.Gamertag.Equals(gamerTag,StringComparison.InvariantCultureIgnoreCase)));
        }
    }
}