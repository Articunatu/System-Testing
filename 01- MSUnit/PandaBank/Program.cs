using System;

namespace PandaBank
{
    class Program
    {
        static void Main()
        {
            BankController bank = new BankController();
            bank.Start();
        }
    }
}