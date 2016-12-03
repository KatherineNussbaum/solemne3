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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioProducto.svc o ServicioProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioProducto : IServicioProducto
    {
        private IProductoBO _productoBO;

        public ServicioProducto()
        {
            this._productoBO = new ProductoBO();
        }

        public IList<Producto> ListarProductos()
        {
            return this._productoBO.ListarProductos();
        }
    }
}
