using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaInterface;
using CapaNegocio;
using CapaEntidad;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDetalleProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioDetalleProducto.svc o ServicioDetalleProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioDetalleProducto : IServicioDetalleProducto
    {
        private DetalleProductoBO _detalleProductoBO;

        public ServicioDetalleProducto()
        {
            this._detalleProductoBO = new DetalleProductoBO();
        }

        public IList<DetalleProducto> ListarDetalleProductos(decimal NumeroBoleta)
        {
            return this._detalleProductoBO.ListarDetalleProductos(NumeroBoleta);
        }
    }
}
