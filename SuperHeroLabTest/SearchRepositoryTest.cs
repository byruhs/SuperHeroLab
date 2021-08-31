using NUnit.Framework;
using SuperHeroLab.Data.Repository;

namespace SuperHeroLabTest
{
    public class SearchRepositoryTest
    {
        private SearchRepository _search;    

        [SetUp]
        public void Setup()
        {
            _search = new SearchRepository();
        }

        [Test]
        public void GetHeroList_ValidSearchValue_ReturnsSuccess()
        {
            string valueSearch = "superman";
            var response = _search.GetHeroList(valueSearch);
            Assert.AreEqual("success", response.Response);
            Assert.Pass();
        }

        [Test]
        public void GetHeroList_InvalidSearchValue_ReturnsError()
        {
            string valueSearch = "invalidhero";
            var response = _search.GetHeroList(valueSearch);
            Assert.AreEqual("error", response.Response);
            Assert.Pass();
        }
    }
}