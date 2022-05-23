using System;

namespace Division_App
{
    class Program
    {
        static void Main()
        {
            Math math = new Math();
            int quote = math.Divide(95, 5);
            Console.WriteLine(quote);
        }
    }
}
