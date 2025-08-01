using prjICE_2_Indexers;

namespace prjICE_2_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPrice()
        {
            Cars cars = new Cars(10000, 150, 200, "Toyota", "Red");
            Assert.AreEqual(cars["carPrice"], 10000);
        }

        [TestMethod]
        public void TestPower()
        {
            Cars cars = new Cars(10000, 150, 200, "Toyota", "Red");
            Assert.AreEqual(cars["carPower"], 150);
        }

        [TestMethod]
        public void TestSpeed()
        {
            Cars cars = new Cars(10000, 150, 200, "Toyota", "Red");
            Assert.AreEqual(cars["carSpeed"], 200);
        }

        [TestMethod]
        public void TestName()
        {
            Cars cars = new Cars(10000, 150, 200, "Toyota", "Red");
            cars[3] = "Ford";
            Assert.AreEqual(cars[3], "Ford");
        }

        [TestMethod]
        public void TestColour()
        {
            Cars cars = new Cars(10000, 150, 200, "Toyota", "Red");
            cars[4] = "Yellow";
            Assert.AreEqual(cars[4], "Yellow");
        }
    }
}
