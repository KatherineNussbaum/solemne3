using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaException;
using CapaInterface;

namespace CapaNegocio
{
    public class VendedorBO : IVendedorBO
    {
        private FuenteSodaEntities _objContext;

        public VendedorBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<Vendedor> ListarVendedores()
        {
            return this._objContext.Vendedor.ToList();
        }

        public Vendedor BuscarVendedor(decimal IdVendedor)
        {
            return this._objContext.Vendedor.FirstOrDefault(v => v.IdVendedor == IdVendedor);
        }
    }
}
