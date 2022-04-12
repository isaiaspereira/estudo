using Livraria.Application.Interface.InterfaceSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services.Login
{
    public class Security : ISecurity
    {
        //public Security()
        //{
        //    new Security();
        //}
        public string EncryptPassword(string password)
        {
            // Configurations
            int workfactor = 12; // 2 ^ (12) = 1024 iterations.

            string salt = BCrypt.Net.BCrypt.GenerateSalt(workfactor);
            string hash = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hash;

        }
        public bool DecryptPassword(string passwordUser, string passwordDb)
        {
            if (BCrypt.Net.BCrypt.Verify(passwordUser, passwordDb))
                return true;

            return false;

        }
    }
}
