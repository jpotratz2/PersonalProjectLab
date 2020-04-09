using System;
namespace PersonalProjectLab
{
    public class Calculate
    {
        private float num1;
        private float num2;

        public float Num1
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

        public float Num2
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

        public float Add()
        {
            return num1 + num2;
        }

        public float Subtract()
        {
            return num1 - num2;
        }

        public float Multiply()
        {
            return num1 * num2;
        }

        public float Divide()
        {
            return num1 / num2;
        }
    }
}