﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class BoletaException : Exception
    {
        public BoletaException(string mensaje) : base(mensaje)
        {

        }
    }
}
