using Microsoft.VisualStudio.TestTools.UnitTesting;
using MenuSums;

namespace MenuSums.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Returns_sum_0_when_no_menu_items()
        {
            var results = MenuSummer.CalculateSums(TestData.NoItems);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(0, results[0]);
        }

        [TestMethod]
        public void Can_handle_null_menu_items()
        {
            var results = MenuSummer.CalculateSums(TestData.WithNulls);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(46, results[0]);
        }
    }
}
