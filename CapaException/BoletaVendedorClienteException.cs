﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class BoletaVendedorClienteException : Exception
    {
        public BoletaVendedorClienteException(string mensaje) : base(mensaje)
        {

        }
    }
}
