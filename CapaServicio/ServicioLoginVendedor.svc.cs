using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaInterface;
using CapaNegocio;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioLoginVendedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioLoginVendedor.svc o ServicioLoginVendedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioLoginVendedor : IServicioLoginVendedor
    {
        private ILoginVendedorBO _loginVendedorBO;

        public ServicioLoginVendedor()
        {
            this._loginVendedorBO = new LoginVendedorBO();
        }

        public LoginVendedor BuscarLoginVendedor(string usuario)
        {
            return this._loginVendedorBO.BuscarLoginVendedor(usuario);
        }

        public bool VerificarLoginVendedor(string usario)
        {
            return this._loginVendedorBO.VerificarLoginVendedor(usario);
        }
    }
}
