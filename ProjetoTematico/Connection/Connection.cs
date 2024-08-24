using System;

namespace NutriFlow.Connection
{
    public class Connection
    {
        #region Consts

        private const string UsuarioSupNot28 = "Gabriela - PLMPRO";
        private const string UsuarioMatheus = "matheus";
        private const string UsuarioLuca = "luca";

        #endregion

        public string ConnectionString
        {
            get { return _connectionString; }
            private set
            {
                string user = Environment.UserName;

                switch (user)
                {
                    case UsuarioSupNot28:
                        _connectionString = Properties.Resources.ConnectionGabriela;
                        break;
                    case UsuarioLuca:
                        _connectionString = Properties.Resources.ConnectionLuca;
                        break;
                    case UsuarioMatheus:
                        _connectionString = Properties.Resources.ConnectionMatheus;
                        break;
                    default:
                        _connectionString = "";
                        break;
                }
            }
        }

        private string _connectionString;

        public Connection()
        {
            ConnectionString = "";
        }
    }
}