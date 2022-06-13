using System;
using System.Collections.Generic;
using System.Text;

namespace _03___XUnit_and_Acceptance_testing
{
    public class App
    {
        Calculator calculator = new Calculator();

        public void Menu()
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

        public void Input()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "+": AdditionInput(); break;
                case "-": SubtractionInput(); break;
                case "*": MultiplicationInput(); break;
                case "/": DivisionInput(); break;
                case "&": HistoryCalculations(); break;
                default:
                    Console.WriteLine("Vänligen skriv ett giltigt räknesätt!");
                    LoadMenu(); break;
            }
        }

        public void LoadMenu()
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

        public void AdditionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den andra termen: ");
            int addend = int.Parse(Console.ReadLine());
            int sum = calculator.Addition(augend, addend);
            string result = AdditionResult(augend, addend, sum);
            Output(result);
        }

        public string AdditionResult(int augend, int addend, int sum)
        {
            return $"Summan av termerna {augend} och {addend} är {sum}!";
        }

        public void SubtractionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int minuend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den andra termen: ");
            int subtrahend = int.Parse(Console.ReadLine());
            int difference = calculator.Subtraction(minuend, subtrahend);
            string result = SubtractionResult(minuend, subtrahend, difference);
            Output(result);
        }

        public string SubtractionResult(int minuend, int subtrahend, int difference)
        {
            return $"Differensen mellan termerna {minuend} och {subtrahend} är {difference}!";
        }

        public void MultiplicationInput()
        {
            Console.WriteLine("Skriv in värdet på den första faktoren: ");
            int multiplicand = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den andra faktoren: ");
            int multiplier = int.Parse(Console.ReadLine());
            int product = calculator.Multiplication(multiplicand, multiplier);
            string result = MultiplicationResult(multiplicand, multiplier, product);
            Output(result);
        }

        public string MultiplicationResult(int multiplicand, int multiplier, int product)
        {
            return $"Produkten av faktorerna {multiplicand} och {multiplier} är {product}!";
        }

        public void DivisionInput()
        {
            Console.WriteLine("Skriv in värdet på täljaren: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på nämnaren: ");
            int divisor = int.Parse(Console.ReadLine());
            int quotend = calculator.Division(dividend, divisor);
            string result = DivisionResult(dividend, divisor, quotend);
            Output(result);
        }

        public string DivisionResult(int dividend, int divisor, int quotend)
        {
            return $"Kvotet mellan täljaren {dividend} och nämnaren {divisor} är {quotend}!";
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
            LoadMenu();
        }

        public void HistoryCalculations()
        {
            Console.WriteLine("\nTidigare beräkningar:\n");
            calculator.History();
            Console.ReadLine();
            LoadMenu();
        }
    }
}
