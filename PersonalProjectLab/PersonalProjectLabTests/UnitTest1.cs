
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
            calc.Num1 = 4.7;
            calc.Num2 = 5;

            double answer1 = calc.Add();

            Assert.AreEqual(9.7, answer1);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 16;
            calc.Num2 = 17;


           double answer2 =  calc.Subtract();

            Assert.AreEqual(-1, answer2);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 12;
            calc.Num2 = 14.5;


            double answer3 = calc.Multiply();

            Assert.AreEqual(174, answer3);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculate calc = new Calculate();
            calc.Num1 = 7;
            calc.Num2 = 3.5;


           double answer4 = calc.Divide();

            Assert.AreEqual(2, answer4);
        }
    }
}
