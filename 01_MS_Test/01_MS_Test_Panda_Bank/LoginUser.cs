using System;
using System.Collections.Generic;

namespace _01_MS_Test_Panda_Bank
{
    public class LoginUser
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        static public decimal[] currencyChange = new decimal[] { 1.00M, 0.11025802M, 0.083344351M, 0.097629977M };
    }
}