using System;

namespace IdeaWeightCalculator
{
    class Program
    {
        static void Main()
        {
            WeightCalculator weightCal = new WeightCalculator
            {
                Height = 180,
                Gender = 'm'
            };

            double weight = weightCal.GetIdealBodyWeight();

            Console.WriteLine($"Den totala vikten är: {weight} kg");

            if (weight == 72.5)
            {
                Console.WriteLine("Testet gick igenom!");
            }
            else
            {
                Console.WriteLine("Testet misslyckades...");
            }


            weightCal.Gender = 'f';
            weight = weightCal.GetIdealBodyWeight();

            Console.WriteLine($"Den totala vikten är: {weight} kg");

            if (weight == 72.5)
            {
                Console.WriteLine("Testet gick igenom!");
            }
            else
            {
                Console.WriteLine("Testet misslyckades...");
            }

            Console.ReadKey();
        }
    }
}
