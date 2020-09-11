using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuSums.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Returns_empty_list_when_no_items()
        {
            var results = MenuSummer.CalculateSums(TestData.NoItems);

            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public void Returns_sum_0_when_no_menu_items()
        {
            var results = MenuSummer.CalculateSums(TestData.NoMenuItems);

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

        [TestMethod]
        public void Correctly_sums_ids_when_all_labels_present()
        {
            var results = MenuSummer.CalculateSums(TestData.AllLabelsPresent);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(60, results[0]);
        }

        [TestMethod]
        public void Correctly_sums_ids_when_all_labels_not_present()
        {
            var results = MenuSummer.CalculateSums(TestData.AllLabelsNotPresent);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(60, results[0]);
        }

        [TestMethod]
        public void Handles_trailing_commas()
        {
            var results = MenuSummer.CalculateSums(TestData.WithTrailingCommas);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(10, results[0]);
        }

        [TestMethod]
        public void Handles_no_menu_key()
        {
            var results = MenuSummer.CalculateSums(TestData.NoMenuKey);

            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public void Handles_no_menu_items_key()
        {
            var results = MenuSummer.CalculateSums(TestData.NoMenuItemsKey);

            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public void Handles_no_id_key()
        {
            var results = MenuSummer.CalculateSums(TestData.NoIdKey);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(0, results[0]);
        }

        [TestMethod]
        public void Correctly_sums_full_data_set()
        {
            var results = MenuSummer.CalculateSums(TestData.FullDataSet);

            Assert.AreEqual(3, results.Count);
            Assert.AreEqual(46, results[0]);
            Assert.AreEqual(0, results[1]);
            Assert.AreEqual(248, results[2]);
        }
    }
}
