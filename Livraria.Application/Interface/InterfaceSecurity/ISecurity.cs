using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interface.InterfaceSecurity
{
    public interface ISecurity
    {
        string EncryptPassword(string hasPassword);
        bool DecryptPassword(string passwordUser, string passwordDb);
    }
}
