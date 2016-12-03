using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class BoletaVendedorCliente

    {
        public decimal NumeroBoleta { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string VendedorNombreCompleto { get; set; }
        public string ClienteRut { get; set; }
        public string ClienteNombreCompleto { get; set; }
        
        public BoletaVendedorCliente()
        {
            this.Estado = this.VendedorNombreCompleto = this.ClienteRut = this.ClienteNombreCompleto = string.Empty;
        }

    }
}
