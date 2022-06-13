using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit_Calculator
{
    public class Output
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
                case "+": AdditionInput();  break;
                case "-": SubtractionInput(); break;
                case "*": MultiplicationInput(); break;
                case "/": DivisionInput(); break;
                case "&": break;
                default: Console.WriteLine("Vänligen skriv ett giltigt räknesätt!"); break;
            }
        }

        static void LoadMenu()
        {
            Console.Clear();
            Menu();
        }

        static void AdditionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int addend = int.Parse(Console.ReadLine());
            int sum = calculator.Addition(augend, addend);
            Console.WriteLine($"Summan av termerna {augend} och {addend} är {sum}!");
            LoadMenu();
        }

        static void SubtractionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int addend = int.Parse(Console.ReadLine());
            int sum = calculator.Addition(augend, addend);
            Console.WriteLine($"Summan av termerna {augend} och {addend} är {sum}!");
            LoadMenu();
        }

        static void MultiplicationInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int addend = int.Parse(Console.ReadLine());
            int sum = calculator.Addition(augend, addend);
            Console.WriteLine($"Summan av termerna {augend} och {addend} är {sum}!");
            LoadMenu();
        }

        static void DivisionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int addend = int.Parse(Console.ReadLine());
            int sum = calculator.Addition(augend, addend);
            Console.WriteLine($"Summan av termerna {augend} och {addend} är {sum}!");
            LoadMenu();
        }
    }
}
