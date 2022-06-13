using Bank_xUnit;
using System;
using NUnit.Framework;

namespace NUnit_Bank_Test
{
    public class BankAccount_Test
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(4300);
        }

        [Test]
        public void Adding_Funds_Update_Balance()
        {
            account.Add(700);

            Assert.AreEqual(5000, account.Balance);
        }

        [Test]
        public void Adding_Negative_Funds_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-300));
        }

        [Test]
        public void Withdrawing_Fund_Update_Balance()
        {
            account.Withdraw(300);

            Assert.AreEqual(4000, account.Balance);
        }

        [Test]
        public void Withdraw_Fund_Negative_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-97.7));
        }

        [Test]
        public void Transfer_Funds_Update_Both_BankAccounts()
        {
            var secondAccount = new BankAccount(3200);

            account.TransferTo(secondAccount, 800);

            Assert.AreEqual(3500, account.Balance);
            Assert.AreEqual(4000, secondAccount.Balance);
        }
    }
}