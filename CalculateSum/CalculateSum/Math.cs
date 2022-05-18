using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateSum
{
    public class Math
    {
        public int Sum(int x, int y)
        {

            int a = x;
            int b = y;


            int result = a + b;

            if (result % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
                Console.WriteLine("The result is : {0}", result);
            }
            else
            {
                Console.WriteLine("The number is Odd");
                Console.WriteLine("The result is : {0}", result);

            }
            return result;
        }
    }
}
