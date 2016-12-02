using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    class ClienteException : Exception
    {
        public ClienteException(string mensaje) : base(mensaje)
        {

        }
    }
}
