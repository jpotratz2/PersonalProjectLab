using System;
namespace PersonalProjectLab
{
    public class Calculate
    {
        private double num1;
        private double num2;

        public double Num1
        {

            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }

        }

        public double Num2
        {

            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }

        }

        public double Add()
        {
            return num1 + num2;
        }

        public double Subtract()
        {
            return num1 - num2;
        }

        public double Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            return num1 / num2;
        }
    }
}