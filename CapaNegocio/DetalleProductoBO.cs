using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaException;
using CapaDato;
using CapaInterface;

namespace CapaNegocio
{
    public class DetalleProductoBO : IDetalleProductoBO
    {
        private FuenteSodaEntities _objContext;

        public DetalleProductoBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<DetalleProducto> ListarDetalleProductos(decimal numeroBoleta)
        {
            IList<DetalleProducto> detalle = (from d in _objContext.DetalleBoleta
                                              join p in _objContext.Producto
                                              on d.IdProducto equals p.IdProducto
                                              where d.NumeroBoleta == numeroBoleta
                                              select new DetalleProducto
                                              {
                                                  IdDetalle = d.IdDetalle,
                                                  NumeroBoleta = d.NumeroBoleta,
                                                  ProductoNombre = p.Nombre,
                                                  ProductoPrecio = p.Precio,
                                                  Cantidad = d.Cantidad
                                              }).ToList();
            return detalle;
        }
    }
}
