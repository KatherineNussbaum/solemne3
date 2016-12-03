using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    interface ILoginVendedorBO
    {
        IList<LoginVendedor> ListarLoginVendedor();

        LoginVendedor BuscarLoginVendedor(int IdVendedor);
    }
}
