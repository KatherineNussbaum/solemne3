using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class DetalleProducto
    {
        public int IdDetalle { get; set; }
        public int NumeroBoleta { get; set; }
        public string ProductoNombre { get; set; }
        public int ProductoPrecio { get; set; }
        public int Cantidad { get; set; }

        public DetalleProducto()
        {
            this.ProductoNombre = string.Empty;
            this.IdDetalle = this.NumeroBoleta = this.ProductoPrecio = this.Cantidad = 0;
        }

    }
}
