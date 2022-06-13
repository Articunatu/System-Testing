using System;

namespace _03___XUnit_and_Acceptance_testing
{
    class Program
    {
        static Calculator calculator = new Calculator();
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Välkommen till miniräknaren för heltal.\n" +
                            "Du kan välja mellan\n" +
                            "\t1. Addition, tryck + \n" +
                            "\t2. Subtraktion, tryck -\n" +
                            "\t3. Multiplikation, tryck *\n" +
                            "\t4. Division, tryck /\n" +
                            "\t5. Se tidigare beräkningar: tryck &\n");
            Input();
        }

        static void Input()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "+": AdditionInput(); break;
                case "-": SubtractionInput(); break;
                case "*": MultiplicationInput(); break;
                case "/": DivisionInput(); break;
                case "&": HistoryCalculations(); break;
                default: Console.WriteLine("Vänligen skriv ett giltigt räknesätt!");
                    LoadMenu(); break;
            }
        }

        static void LoadMenu()
        {

            Console.WriteLine("\nVill du stänga av miniräknaren, skriv NEJ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() != "NEJ")
            {
                Console.Clear();
                Menu();
            }
            else
            {

            }
        }

        static void AdditionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den andra termen: ");
            int addend = int.Parse(Console.ReadLine());
            int sum = calculator.Addition(augend, addend);
            AdditionResult(augend, addend, sum);
        }

        private static void AdditionResult(int augend, int addend, int sum)
        {
            Console.WriteLine($"Summan av termerna {augend} och {addend} är {sum}!");
            LoadMenu();
        }

        static void SubtractionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int minuend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den andra termen: ");
            int subtrahend = int.Parse(Console.ReadLine());
            int difference = calculator.Subtraction(minuend, subtrahend);
            SubtractionResult(minuend, subtrahend, difference);
        }

        private static void SubtractionResult(int minuend, int subtrahend, int difference)
        {
            Console.WriteLine($"Differensen mellan termerna {minuend} och {subtrahend} är {difference}!");
            LoadMenu();
        }

        static void MultiplicationInput()
        {
            Console.WriteLine("Skriv in värdet på den första faktoren: ");
            int multiplicand = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den andra faktoren: ");
            int multiplier = int.Parse(Console.ReadLine());
            int product = calculator.Multiplication(multiplicand, multiplier);
            MultiplicationResult(multiplicand, multiplier, product);
        }

        private static void MultiplicationResult(int multiplicand, int multiplier, int product)
        {
            Console.WriteLine($"Produkten av faktorerna {multiplicand} och {multiplier} är {product}!");
            LoadMenu();
        }

        static void DivisionInput()
        {
            Console.WriteLine("Skriv in värdet på täljaren: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på nämnaren: ");
            int divisor = int.Parse(Console.ReadLine());
            int quotend = calculator.Division(dividend, divisor);
            DivisionResult(dividend, divisor, quotend);
        }

        public static void DivisionResult(int dividend, int divisor, int quotend)
        {
            Console.WriteLine($"Kvotet mellan täljaren {dividend} och nämnaren {divisor} är {quotend}!");
            LoadMenu();
        }

        static void HistoryCalculations()
        {
            Console.WriteLine("\nTidigare beräkningar:\n");
            calculator.History();
            Console.ReadLine();
            LoadMenu();
        }
    }
}