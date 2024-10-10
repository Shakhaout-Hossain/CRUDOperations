namespace CRUDTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
             MyMath myM = new MyMath();
            double a = 2, b = 3.5, expected = 5.5;
            //act
            double actual = myM.Add(a, b);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}