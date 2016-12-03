using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    public interface IVendedorBO
    {
        IList<Vendedor> ListarVendedores();

        Vendedor BuscarVendedor(decimal idVendedor);
        Vendedor BuscarVendedorUsuario(string usuario);
    }
}
