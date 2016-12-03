using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;
using CapaInterface;
using CapaException;

namespace CapaNegocio
{
    public class BoletaVendedorClienteBO : IBoletaVendedorClienteBO
    {
        private FuenteSodaEntities _objContext;
        public BoletaVendedorClienteBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<BoletaVendedorCliente> ListarBoletaVendedorCliente(string usuario)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
            {
                throw new BoletaVendedorClienteException("Falta: usuario");
            }
            IList<BoletaVendedorCliente> boletaVendedorCliente = (from b in _objContext.Boleta
                                                                  join c in _objContext.Cliente
                                                                  on b.IdCliente equals c.IdCliente
                                                                  join v in _objContext.Vendedor
                                                                  on b.IdVendedor equals v.IdVendedor
                                                                  where v.Usuario == usuario
                                                                  select new BoletaVendedorCliente
                                                                  {
                                                                    NumeroBoleta = b.NumeroBoleta,
                                                                    Fecha = b.Fecha,
                                                                    Estado = b.Estado,
                                                                    ClienteRut = c.Rut,
                                                                    ClienteNombreCompleto = c.NombreCompleto
                                                                  }).ToList();
            return boletaVendedorCliente;

        }
    }
}
