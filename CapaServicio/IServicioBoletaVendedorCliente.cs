using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaEntidad;
using CapaInterface;
using CapaNegocio;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioBoletaVendedorCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioBoletaVendedorCliente
    {
        [OperationContract]
        IList<BoletaVendedorCliente> ListarBoletaVendedorCliente(decimal idVendedor);
    }
}
