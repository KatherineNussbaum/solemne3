using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    public interface IClienteBO
    {
        bool VerificarCliente(string rut);
        bool EliminarCliente(string rut);
        bool AgregarCliente(string rut, string nombreCompleto, string direccion);
        bool ModificarCliente(decimal idCliente, string rut, string nombreCompleto, string direccion);
        Cliente BuscarCliente(string rut);
    }
}
