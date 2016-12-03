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
    public class BoletaBO : IBoletaBO
    {
        private FuenteSodaEntities _objContext;
        public BoletaBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<Boleta> ListarBoletaCliente(decimal idCliente)
        {
            if(idCliente <= 0)
            {
                throw new BoletaException("Falta: id de cliente");
            }
            return this._objContext.Boleta.Where(b => b.IdCliente == idCliente).ToList();
        }

        public bool VerificarBoletaCliente(decimal idCliente)
        {
            if (idCliente <= 0)
            {
                throw new BoletaException("Falta: id de cliente");
            }
            return this._objContext.Boleta.Any(b => b.IdCliente == idCliente);
        }
    }
}
