using System;

namespace Division_App
{
    class Program
    {
        static void Main()
        {
            Math math = new Math();
            int quote = math.Divide(95, 5);
            int quote2 = math.Divide(144, -12);
            Console.WriteLine(quote);
            Console.WriteLine(quote2);
        }
    }
}
