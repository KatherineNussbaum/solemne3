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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        bool VerificarCliente(string rut);
        [OperationContract]
        bool EliminarCliente(string rut);
        [OperationContract]
        bool AgregarCliente(string rut, string nombreCompleto, string direccion);
        [OperationContract]
        bool ModificarCliente(decimal idCliente, string rut, string nombreCompleto, string direccion);
        [OperationContract]
        Cliente BuscarCliente(string rut);
    }
}
