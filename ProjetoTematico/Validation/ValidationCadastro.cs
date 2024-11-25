using System; 
using System.Net.Mail;
using NutriFlow.Objects;

namespace NutriFlow.Validation
{
    internal class ValidationCadastro
    {
        public bool IsUserNull(ObjectUser user)
        {
            return user == null;
        }

        public bool IsUserFilled(ObjectUser user)
        {
            bool isUserFilled = false;

            if (user.Nome != "" && user.Sobrenome != "" && user.Genero != "" && user.Email != "" && user.Senha != "")
            {
                isUserFilled = true;
            }
            return isUserFilled;
        }

        internal bool IsEmailValido(string email)
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
