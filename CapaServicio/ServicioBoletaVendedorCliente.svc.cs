using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaEntidad;
using CapaNegocio;
using CapaInterface;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioBoletaVendedorCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioBoletaVendedorCliente.svc o ServicioBoletaVendedorCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioBoletaVendedorCliente : IServicioBoletaVendedorCliente
    {
        private IBoletaVendedorClienteBO _boletaVendedorClienteBO;
        
        public IList<BoletaVendedorCliente> ListarBoletaVendedorCliente(decimal idVendedor)
        {
            return this._boletaVendedorClienteBO.ListarBoletaVendedorCliente(idVendedor);
        }
    }
}
