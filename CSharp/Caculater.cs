using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Caculater
    {

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }
        public static float Add(int a, float b)
        {
            float result = a + b;
            return result;

        }

        public static int Minus(int a, int b)
        {
            int result = a - b;
            return result;
        }
        public static float Minus(float a, float b)
        {
            float result = a - b;
            return result;
        }
        public static float Minus(int a, float b)
        {
            float result = a - b;
            return result;

        }

        public static int Devide(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("0 으로 나눌수 없습니다");
            }
            int result = a / b;
            return result;
        }
        public static float Devide(float a, float b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("0 으로 나눌수 없습니다");
            }
                float result = a / b;
                return result;
            
        }
        public static float Devide(int a, float b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("0 으로 나눌수 없습니다");
            }

            float result = a / b;
            return result;
        }

        public static int Mult(int a, int b)
        {
            int result = a * b;
            return result;
        }
        public static float Mult(int a, float b)
        {
            float result = a * b;
            return result;
        }
        public static float Mult(float a, float b)
        {
            float result = a * b;
            return result;
        }

    }
}
