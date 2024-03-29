using System;
using Xunit;
using Password_xUnit;

namespace PasswordValidator.TestXUnit
{
    public class ValidityTest
    {
        [Fact]
        public void ValidPassword()
        {
            var passwordValidator = new PasswordValidation();
            string password = "Nisdbusdm15123%";

            bool isValid = passwordValidator.IsValid(password);

            Assert.True(isValid, $"The password {password} is not valid!");
        }

        [Fact]
        public void NotValidPassword()
        {
            var passwordValidator = new PasswordValidation();
            string password = "aosdbasd1234";

            bool isValid = passwordValidator.IsValid(password);

            Assert.False(isValid, $"The password {password} should not be valid!");
        }

        [Theory]
        [InlineData("Pwbdudald25123%", true, 1)]
        [InlineData("ewrhu5234", true, 2)]
        [InlineData("Fake password", true, 5)]
        [InlineData("Fake password", false, 8)]
        [InlineData("Rea234�]$�password", true, 9)]
        public void ValidatePasswordTheory(string password, bool result, int number)
        {
            var passwordValidator = new PasswordValidation();
            bool isValid = passwordValidator.IsValid(password);

            Assert.Equal(result, isValid);
        }
    }
}
