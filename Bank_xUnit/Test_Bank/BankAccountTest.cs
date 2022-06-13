using System;
using Xunit;
using Bank_xUnit;

namespace Test_Bank
{
    public class BankAccountTest
    {
        [Fact]
        public void Adding_Funds_Update_Balance()
        {
            var account = new BankAccount(1000);

            account.Add(100);

            Assert.Equal(1100, account.Balance);
        }

        [Fact]
        public void Adding_Negative_Funds_Throws()
        {
            var account = new BankAccount(1000);

            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-100));
        }

        [Fact]
        public void Withdrawing_Fund_Update_Balance()
        {
            var account = new BankAccount(444);

            account.Withdraw(35.79);

            Assert.Equal(408.21, account.Balance);
        }

        [Fact]
        public void Withdraw_Fund_Negative_Throws()
        {
            var account = new BankAccount(850);

            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-97.7));
        }

        [Fact]
        public void Transfer_Funds_Update_Both_BankAccounts()
        {
            var firstAccount = new BankAccount(1000);
            var secondAccount = new BankAccount(2999);

            firstAccount.TransferTo(secondAccount, 1);

            Assert.Equal(999, firstAccount.Balance);
            Assert.Equal(3000, secondAccount.Balance);
        }

        [Fact]
        public void Transfer_Funds_To_NullAccount_Throws()
        {
            var account = new BankAccount(800);

            Assert.Throws<ArgumentNullException>(() => account.TransferTo(null, 200));
        }
    }
}
