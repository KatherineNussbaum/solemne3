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
    public class ProductoBO : IProductoBO
    {
        private FuenteSodaEntities _objContext;

        public ProductoBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<Producto> ListarProductos()
        {
            return this._objContext.Producto.ToList();
        }
    }
}
