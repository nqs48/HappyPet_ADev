using System.Collections.Generic;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia.AppRepositorios{

    public interface IRepositorioCliente{

        //retornar una lista con todos los clientes
        IEnumerable<Cliente> GetAllClientes();

        //Crear Cliente
        Cliente AddCliente(Cliente cliente);

        //Actualizar Cliente
        Cliente UpdateCliente(Cliente clienteActualizado);

        //Eliminar Cliente
        Cliente DeleteCliente(int idCliente);

        //Buscar Cliente
        Cliente GetCliente(int idCliente);

    }
}