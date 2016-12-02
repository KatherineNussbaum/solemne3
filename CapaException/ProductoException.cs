using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    class ProductoException : Exception
    {
        public ProductoException(string mensaje) : base(mensaje)
        {

        }
    }
}
