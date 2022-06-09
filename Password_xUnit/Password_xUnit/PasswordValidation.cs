using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Password_xUnit
{
    public class PasswordValidation
    {
        public bool IsValid(string password)
        {
            Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})");
            return passwordPolicyExpression.IsMatch(password);
        }
    }
}
