using NUnit.Framework;
using SuperHeroLab.Data.Repository;

namespace SuperHeroLabTest
{
    public class HeroSearchRepositoryTest
    {
        private HeroSearchRepository _search;    

        [SetUp]
        public void Setup()
        {
            _search = new HeroSearchRepository();
        }

        [Test]
        public void GetHero_ValidId_ReturnsSuccess()
        {
            int id = 644;
            var response = _search.GetHero(id);
            Assert.AreEqual("success", response.Response);
            Assert.Pass();
        }

        [Test]
        public void GetHero_InvalidId_ReturnsError()
        {
            int id = 999999999;
            var response = _search.GetHero(id);
            Assert.AreEqual("error", response.Response);
            Assert.Pass();
        }
    }
}