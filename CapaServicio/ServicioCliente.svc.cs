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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioCliente.svc o ServicioCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioCliente : IServicioCliente
    {
        private IClienteBO _clienteBO;
        public ServicioCliente()
        {
            this._clienteBO = new ClienteBO();
        }

        public bool AgregarCliente(string rut, string nombreCompleto, string direccion)
        {
            return this._clienteBO.AgregarCliente(rut, nombreCompleto, direccion);
        }

        public Cliente BuscarCliente(string rut)
        {
            return this._clienteBO.BuscarCliente(rut);
        }

        public bool EliminarCliente(string rut)
        {
            return this._clienteBO.EliminarCliente(rut);
        }

        public IList<Cliente> ListarClientes()
        {
            return this._clienteBO.ListarClientes();
        }

        public bool ModificarCliente(decimal idCliente, string rut, string nombreCompleto, string direccion)
        {
            return this._clienteBO.ModificarCliente(idCliente, rut, nombreCompleto, direccion);
        }

        public bool VerificarCliente(string rut)
        {
            return this._clienteBO.VerificarCliente(rut);
        }
    }
}
