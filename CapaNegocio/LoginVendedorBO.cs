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
    public class LoginVendedorBO : ILoginVendedorBO
    {
        private FuenteSodaEntities _objContext;

        public LoginVendedorBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<LoginVendedor> ListarLoginVendedor()
        {
            return this._objContext.LoginVendedor.ToList();
        }

        public LoginVendedor BuscarLoginVendedor(string usuario)
        {
            return this._objContext.LoginVendedor.FirstOrDefault(v => v.Usuario == usuario);
        }
    }
}
