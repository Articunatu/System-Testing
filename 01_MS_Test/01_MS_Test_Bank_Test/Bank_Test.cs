using _01_MS_Test_Panda_Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_MS_Test_Bank_Test
{
    [TestClass]
    public class Bank_Test
    {
        [TestMethod]
        [Priority(1)]
        public void GetExchangeRate_When_SendCurrency_SEK_And_RecieveCurrency_EUR_And_MoneyAmount_10000_With_Result_976_2997()
        {
            Admin a = new Admin();
            a.AdminSetup();
            Customer customer = a.ListOfCustomers[0];

            Accounts send = customer.ListOfAccounts[0];
            Accounts recieve = customer.ListOfAccounts[1];
                                              ///EUR       ///SEK
            decimal expectedRate = 10000 * (0.097629977M / 1.00M); ///976.29977

            decimal actualRate = a.ListOfCustomers[0].ExchangeRate(send, recieve, 10000);

            Assert.AreEqual(expectedRate, actualRate);
        }

        [TestMethod]
        [Priority(1)]
        public void GetExchangeRate_When_SendCurrency_USD_And_RecieveCurrency_GBP_And_MoneyAmount_999_45_With_Result_1322_19373()
        {
            Admin a = new Admin();
            a.AdminSetup();
            Customer customer = a.ListOfCustomers[1];

            Accounts send = customer.ListOfAccounts[1];
            Accounts recieve = customer.ListOfAccounts[0];
            ///EUR       ///SEK
            decimal expectedRate = 999.45M * (0.11025802M / 0.083344351M); ///1322.19373 

            decimal actualRate = a.ListOfCustomers[0].ExchangeRate(send, recieve, 999.45f);

            Assert.AreEqual(decimal.Round(expectedRate, 5), decimal.Round(actualRate, 5));
        }
        
        [TestMethod]
        [Priority(2)]
        public void GetExchangeRate_When_SendCurrency_SEK_And_RecieveCurrency_SEK_And_MoneyAmount_587_With_Result_587()
        {
            Admin a = new Admin();
            a.AdminSetup();
            Customer customer = a.ListOfCustomers[2];

            Accounts send = customer.ListOfAccounts[0];
            Accounts recieve = customer.ListOfAccounts[1];
            ///EUR       ///SEK
            decimal expectedRate = 587 * (1 / 1); ///1322.19373 

            decimal actualRate = a.ListOfCustomers[0].ExchangeRate(send, recieve, 587);

            Assert.AreEqual(expectedRate, actualRate);
        }

        [TestMethod]
        [Priority(3)]
        public void GetSaveCalculation_When_RecieveAmount_4000_And_SendAmount_5000()
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
            Assert.AreNotEqual(expected.SendAmount, 646546);
        }

        [TestMethod]
        [Priority(3)]
        public void GetSaveCalculation_When_RecieveAmount_789_78_And_SendAmount_1562_394()
        {
            Calculation expected = new Calculation
            {
                RecieveAmount = 789.78f,
                SendAmount = 1562.394f,
            };

            Customer customer = new Customer(null, null);
            customer.SaveCalculations(1562.394f, 789.78f, null, null);
            Calculation actual = BankController.queuedCalculations.Peek();

            Assert.AreEqual(expected.RecieveAmount, actual.RecieveAmount);
            Assert.AreNotEqual(expected.SendAmount, 646546);
        }
    }
}
