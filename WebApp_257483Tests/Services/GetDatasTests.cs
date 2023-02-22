using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApp_257483.Services.Tests {
    [TestClass()]
    public class GetDatasTests {
        private GetDatas _getData;

        public GetDatasTests() {
            _getData = new GetDatas();
        }

        [TestMethod()]
        public void GetDataTest1() {
            var result = _getData.GetDataAssets("1029TH", "5");
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetDataTest2() {
            var result = _getData.GetDataAssets("", "5");
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetDataTest3() {
            var result = _getData.GetDataAssets("1029TH", "");
            Assert.IsNotNull(result);
        }

    }
}