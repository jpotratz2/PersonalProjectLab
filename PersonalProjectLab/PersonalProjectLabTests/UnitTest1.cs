
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 4.7f;
            calc.Num2 = 5;

            calc.Add();

        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 16;
            calc.Num2 = 12.2f;


            calc.Subtract();

        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 12;
            calc.Num2 = 14.5f;


            calc.Multiply();

        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 7;
            calc.Num2 = 1.69f;


            calc.Divide();
        }
    }
}
