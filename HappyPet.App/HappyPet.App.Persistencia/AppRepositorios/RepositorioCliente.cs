using System.Collections.Generic;
using System.Linq;
using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;


namespace HappyPet.App.Persistencia.AppRepositorios{

    public class RepositorioCliente : IRepositorioCliente
    {

        private readonly AppContext _appContext;

        public RepositorioCliente(AppContext appContext)
        {
            _appContext= appContext;
        }



        //METODO PARA AGREGAR UN CLIENTE
        Cliente IRepositorioCliente.AddCliente(Cliente cliente){
            var clienteAdicionado= _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        //METODO PARA ELIMINAR CLIENTE
        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
            if (clienteEncontrado==null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        //METODO PARA RETORNAR TODOS LOS CLIENTES
        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.Clientes;
        }

        //METODO PARA RETORNAR UN CLIENTE
        Cliente IRepositorioCliente.GetCliente(int idCliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
            return clienteEncontrado;
           
        }

        //METODO PARA ACTUALIZAR UN Cliente
        Cliente IRepositorioCliente.UpdateCliente(Cliente Cliente, int idCliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
            if(clienteEncontrado!=null)
            {
                clienteEncontrado.Nombres= Cliente.Nombres;
                clienteEncontrado.Apellidos= Cliente.Apellidos;
                clienteEncontrado.DocumentoIdentidad= Cliente.DocumentoIdentidad;
                clienteEncontrado.Telefono= Cliente.Telefono;
                clienteEncontrado.Direccion= Cliente.Direccion;

                _appContext.SaveChanges();
                
            }
            return clienteEncontrado;
        }


    }
}