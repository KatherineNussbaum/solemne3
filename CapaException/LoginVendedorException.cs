﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    class LoginVendedorException : Exception
    {
        public LoginVendedorException(string mensaje) : base(mensaje)
        {

        }
    }
}
