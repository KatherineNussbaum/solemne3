using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ProductoException : Exception
    {
        public ProductoException(string mensaje) : base(mensaje)
        {

        }
    }
}
