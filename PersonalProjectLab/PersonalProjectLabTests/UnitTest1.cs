using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalListPrice()
        {
            MyGroceryList engine = new MyGroceryList();

            int totalPrice = engine.TotalPrice();
            Assert.AreEqual();
        }
    }
}
