using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaInterface;
using CapaException;

namespace CapaNegocio
{
    public class ClienteBO : IClienteBO
    {
        private FuenteSodaEntities _objContext;
        public ClienteBO()
        {
            this._objContext = new FuenteSodaEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public bool AgregarCliente(string rut, string nombreCompleto, string direccion)
        {
            if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new ClienteException("Falta: rut cliente");
            }
            else if(!this.VerificarCliente(rut))
            {
                Cliente cliente = new Cliente
                {
                    Rut = rut,
                    NombreCompleto = nombreCompleto,
                    Direccion = direccion
                };
                this._objContext.Cliente.Add(cliente);
                return this._objContext.SaveChanges() > 0;
            }
            return false;
        }

        public Cliente BuscarCliente(string rut)
        {
            return this._objContext.Cliente.FirstOrDefault(c => c.Rut == rut);
        }

        public bool EliminarCliente(string rut)
        {
            if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new ClienteException("Falta: Rut Cliente");
            }
            else if (this.VerificarCliente(rut))
            {
                Cliente cliente = this.BuscarCliente(rut);
                this._objContext.Cliente.Remove(cliente);
                return this._objContext.SaveChanges() > 0;
            }
            return false;
        }

        public IList<Cliente> ListarClientes()
        {
            return this._objContext.Cliente.ToList();
        }

        public bool ModificarCliente(decimal idCliente, string rut, string nombreCompleto, string direccion)
        {
            if(idCliente <= 0)
            {
                throw new ClienteException("Falta: Id Cliente");
            }
            else if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new ClienteException("Falta: Rut Cliente");
            }
            else if (this.VerificarCliente(rut))
            {
                Cliente cliente = this.BuscarCliente(rut);
                cliente.Rut = rut;
                cliente.NombreCompleto = nombreCompleto;
                cliente.Direccion = direccion;
                return this._objContext.SaveChanges() > 0;
            }
            return false;
        }

        public bool VerificarCliente(string rut)
        {
            return this._objContext.Cliente.Any(c => c.Rut == rut);
        }
    }
}
