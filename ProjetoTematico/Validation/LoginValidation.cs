using System;
using System.Net.Mail;

namespace NutriFlow.Validation
{
    internal class LoginValidation
    {
        public bool IsLoginFilled(string email, string password)
        {
            bool loginPreenchido = false;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                loginPreenchido = true;
            }
            return loginPreenchido;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);

                return mailAddress.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
