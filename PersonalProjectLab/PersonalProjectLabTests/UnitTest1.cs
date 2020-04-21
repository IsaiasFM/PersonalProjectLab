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

            engine.AddToList("Apple", 1.99m);
            engine.AddToList("Orange", 1.89m);
            engine.AddToList("Carrots", 3.88m);

            decimal totalPrice = engine.TotalPrice();
            Assert.AreEqual(7.76m, totalPrice);

        }
    }
}
