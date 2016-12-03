using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    interface IVendedorBO
    {
        IList<Vendedor> ListarVendedores();

        Vendedor BuscarVendedor(int IdVendedor);
    }
}
