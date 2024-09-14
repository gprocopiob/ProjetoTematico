using NutriFlow.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

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

            if (user.Id != 0 && user.Nome != "" && user.Sobrenome != "" && user.Genero != "" && user.Email != "" && user.Senha != "")
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
