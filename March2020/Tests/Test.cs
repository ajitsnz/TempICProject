using March2020.Code;
using NUnit.Framework;

namespace March2020.Tests
{
    public class Test : BaseTest
    {

        [Test]
        public void SumTC1()
        {
            //Arrange 
            int num1 = 10;
            int num2 = 20;
            int expectedSum = 30;


            //ACT 
            int actualSum = Math.AddStatic(num1, num2);


            //Assert
            Assert.AreEqual(expectedSum, actualSum);

        }

        [TestCase(1, 2, 3)]
        [TestCase(-1, 2, 1)]
        [TestCase(1000, 2, 1002)]
        [TestCase(0, -2, -2)]
        public void SumTC2(int num1, int num2, int expectedSum)
        {
            //ACT 
            int actualSum = Math.AddStatic(num1, num2);
            // sdsd
            //Assert
            Assert.AreEqual(expectedSum, actualSum);

        }


        [TestCase(0, -2, -2)]
        [Ignore("....")]
        public void SumTC3NonStatic(int num1, int num2, int expectedSum)
        {
            Math math = new Math();

            //ACT 
            int actualSum = math.AddNonStatic(num1, num2);

            //Assert
            Assert.AreEqual(expectedSum, actualSum);

        }


        public int Sum1(int i, int j)
        {
            return sum(i, j);

        }

        private int sum(int i, int j)
        {
            return i + j;
        }

    }
}