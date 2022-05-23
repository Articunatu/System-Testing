using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBank
{
    public class BankRepository
    {
        IEnumerable<Accounts> accounts;
        Admin a = new Admin();
        public BankRepository()
        {
            a.AdminSetup();
            accounts = a.ListOfCustomers[0].ListOfAccounts;
        }

        public IEnumerable<Accounts> GetAccounts()
        {
            return accounts;
        }
    }
}
