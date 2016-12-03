using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class DetalleProductoException : Exception
    {
        public DetalleProductoException(string mensaje) : base(mensaje)
        {

        }
    }
}
