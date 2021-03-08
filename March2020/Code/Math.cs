using NUnit.Framework;

namespace March2020.Code
{
    public class Math
    {
        // total = num1 + num2;

        public int AddNonStatic(int a, int b)
        {
            return a + b;
        }

        public static int AddStatic(int a, int b)
        {
            return a + b;
        }



        // public int SumFunciton1(int a, int b) => a + b;
        // int i = 10;

        //return Type FunctinName (inputs) 
        // int asdfads(int a, int b)


        [TestCase(1, 2)]
        [Category("Practice test")]
        public void AddStatic1(int a, int b)
        {
            TestContext.WriteLine(a + b);
        }


    }
}
