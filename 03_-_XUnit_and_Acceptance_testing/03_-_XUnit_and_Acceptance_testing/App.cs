using System;
using System.Collections.Generic;
using System.Text;

namespace _03___XUnit_and_Acceptance_testing
{
    public class App
    {
        Calculator calculator = new Calculator();

        public int? savedResult = null;

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
                default: LoadMenu(); break;
            }
        }

        public void LoadMenu()
        {

            Console.WriteLine("\nVill du stänga av miniräknaren, skriv JA");
            string answer = Console.ReadLine();
            if (answer.ToUpper() != "JA")
            {
                Console.Clear();
                Menu();
            }
            else
            {

            }
        }

        public int NumberInput()
        {
            int input = 0;
            bool isException = false;
            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("OBS! Detta värdet kan ej vara tomt!");
                    isException = true;
                }

            } while (isException);

            return input;
        }

        public List<int> MultipleInputs()
        {
            List<int> inputs = new List<int>();
            bool isDone = false;
            while (!isDone)
            {
                Console.WriteLine("Skriv in ett till värde:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numberResult))
                {
                    inputs.Add(numberResult);
                }
                else
                {
                    isDone = true;
                }
            }
            return inputs;
        }

        ///Takes multiple inputs
        public void AdditionInput()
        {
            Console.WriteLine("Skriv in värdet på den första termen: ");
            int augend = NumberInput();
            Console.WriteLine(augend);
            Console.WriteLine("Skriv in värdet på nästa andra termen: ");
            int addend = NumberInput();

            List<int> addends = new List<int>();
            addends.Add(addend);
            addends.AddRange(MultipleInputs());

            int sum = calculator.AdditionMulti(augend, addends.ToArray());

            string result = AdditionMultiResult(augend, addends.ToArray(), sum);
            Output(result);
        }

        public string AdditionResult(int augend, int addend, int sum)
        {
            return $"Summan av termerna {augend} och {addend} är {sum}!";
        }

        public string AdditionMultiResult(int augend, int[] addends, int sum)
        {
            if (addends.Length < 2)
            {
                return $"Summan av termerna {augend} och {addends[0]} är {sum}!";
            }
            string text = $"Summan av termerna {augend}, {addends[0]}";
            for (int i = 1; i < addends.Length; i++)
            {
                if (i != addends.Length-1)
                {
                    text += $" ,{addends[i]}";
                }
                else
                {
                    text += $" och {addends[i]}";
                }
            }
            text += $" är {sum}!";
            return text;
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

        public int ResUseResult()
        {
            if (savedResult != null)
            {
                Console.WriteLine("Vill du återvända ditt sparade resultat");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "JA")
                {
                    return (int)savedResult;
                }
            }
            return 1;
        }

        public void SaveResult(int result)
        {
            savedResult = result;
        }
    }
}