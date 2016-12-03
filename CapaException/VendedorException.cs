using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class VendedorException : Exception
    {
        public VendedorException(string mensaje) : base(mensaje)
        {

        }
    }
}
