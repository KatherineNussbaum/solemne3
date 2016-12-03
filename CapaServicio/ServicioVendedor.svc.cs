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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioVendedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioVendedor.svc o ServicioVendedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioVendedor : IServicioVendedor
    {
        private IVendedorBO _vendedorBO;

        public ServicioVendedor()
        {
            this._vendedorBO = new VendedorBO();
        }
        public Vendedor BuscarVendedor(decimal idVendedor)
        {
            return this._vendedorBO.BuscarVendedor(idVendedor);
        }

        public Vendedor BuscarVendedorUsuario(string usuario)
        {
            return this._vendedorBO.BuscarVendedorUsuario(usuario);
        }

        public IList<Vendedor> ListarVendedores()
        {
            return this._vendedorBO.ListarVendedores();
        }
    }
}
