using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    class DetalleBoletaException : Exception
    {
        public DetalleBoletaException(string mensaje) : base(mensaje)
        {

        }
    }
}
