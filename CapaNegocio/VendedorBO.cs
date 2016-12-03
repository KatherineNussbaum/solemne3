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

        public Vendedor BuscarVendedor(decimal idVendedor)
        {
            if(idVendedor <= 0)
            {
                throw new VendedorException("Falta: id de vendedor");
            }
            return this._objContext.Vendedor.FirstOrDefault(v => v.IdVendedor == idVendedor);
        }

        public Vendedor BuscarVendedorUsuario(string usuario)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
            {
                throw new VendedorException("Falta: usuario");
            }
            return this._objContext.Vendedor.FirstOrDefault(v => v.Usuario == usuario);
        }
    }
}
