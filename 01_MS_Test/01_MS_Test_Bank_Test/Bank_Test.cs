using _01_MS_Test_Panda_Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _01_MS_Test_Bank_Test
{
    [TestClass]
    public class Bank_Test
    {
        [TestMethod]
        public void GetExchangeRate_When_SendCurrency_SEK_And_RecieveCurrency_EUR_And_MoneyAmount_10000_With_Result_976_2997()
        {
            Admin a = new Admin();
            a.AdminSetup();
            Customer customer = a.ListOfCustomers[0];

            Accounts first = customer.ListOfAccounts[0];
            Accounts second = customer.ListOfAccounts[1];
                                              ///EUR       ///SEK
            decimal expectedRate = 10000 * (0.097629977M / 1.00M); ///976.29977

            decimal actualRate = a.ListOfCustomers[0].ExchangeRate(first, second, 10000);

            Assert.AreEqual(expectedRate, actualRate);
        }

        [TestMethod]
        public void GetSaveCalculation_When()
        {
            Calculation expected = new Calculation
            {
                RecieveAmount = 4000,
                SendAmount = 5000,
            };

            Customer customer = new Customer(null, null);
            customer.SaveCalculations(5000, 4000, null, null);
            Calculation actual = BankController.queuedCalculations.Peek();

            Assert.AreEqual(expected.RecieveAmount, actual.RecieveAmount);
            Assert.AreEqual(expected.SendAmount, 646546);
        }
    }
}
