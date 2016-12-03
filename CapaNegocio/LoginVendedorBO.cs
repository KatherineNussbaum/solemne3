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

        public bool VerificarLoginVendedor(string usuario)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
            {
                throw new LoginVendedorException("Falta: usuario");
            }
            return this._objContext.Vendedor.Any(v => v.Usuario == usuario);
        }

        public LoginVendedor BuscarLoginVendedor(string usuario)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
            {
                throw new LoginVendedorException("Falta: usuario");
            }
            return this._objContext.LoginVendedor.FirstOrDefault(v => v.Usuario == usuario);
        }
    }
}
