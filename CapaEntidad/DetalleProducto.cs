using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleProducto
    {
        public decimal IdDetalle { get; set; }
        public decimal? NumeroBoleta { get; set; }
        public string ProductoNombre { get; set; }
        public decimal? ProductoPrecio { get; set; }
        public decimal Cantidad { get; set; }

        public DetalleProducto()
        {
            this.ProductoNombre = string.Empty;
            
        }

    }
}
