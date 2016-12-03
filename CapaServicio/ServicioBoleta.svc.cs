using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaNegocio;
using CapaInterface;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioBoleta" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioBoleta.svc o ServicioBoleta.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioBoleta : IServicioBoleta
    {

        private IBoletaBO _boletaBO;

        public ServicioBoleta()
        {
            this._boletaBO = new BoletaBO();
        }

        public IList<Boleta> ListarBoletaCliente(decimal idCliente)
        {
            return this._boletaBO.ListarBoletaCliente(idCliente);
        }

        public bool VerificarBoletaCliente(decimal idCliente)
        {
            return this._boletaBO.VerificarBoletaCliente(idCliente);
        }
    }
}
