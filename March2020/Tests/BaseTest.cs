using NUnit.Framework;

namespace March2020.Tests
{
    public class BaseTest
    {

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        [SetUp] //Before Tests Case
        public void Setup()
        {
            //Opening browser 
        }

        [TearDown] // //After Tests Case
        public void TearDown()
        {
            //Clean
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
