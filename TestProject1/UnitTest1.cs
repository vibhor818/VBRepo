using DALayer;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Multiply()
        {
            
            DataOperations operations = new DataOperations();
            int i = 10;
            int j = 20;
            int expected = 210;
          int actual=  operations.Multiply(i, j);
            Assert.AreEqual(expected, actual);

        }
    }
}