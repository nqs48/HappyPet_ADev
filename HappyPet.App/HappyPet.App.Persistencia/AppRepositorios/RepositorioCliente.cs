using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using System.Linq;

namespace HappyPet.App.Persistencia.AppRepositorios
{

    public class RepositorioCliente : IRepositorioCliente
    {
        List<Cliente> listaClientes;

      //  CREACION DE INSTANCIAS TIPO CLIENTE PARA AGREGAR A LA LISTA
        Cliente c1= new Cliente(1,"Nestor","Quiroga","10745577907","3102095353","Cra 7D no 183 51");
        Cliente c2= new Cliente(2,"Jesus","Benitez","1043289467","3134242424","Av Ferro no 122 67");
        Cliente c3= new Cliente(3,"Vero","Aguirre","1092447297","3205978398","Av Master no 124 55");
        Cliente c4= new Cliente(4,"Dani","Zambrano","1084267482","3119845793","Cra 7h no 382 - 44");
        Cliente c5= new Cliente(5,"Will","Beltran","1024987222","32943724944","Calle 19 no 16 99");
        Cliente c6= new Cliente(6,"Noah","Moretz","1034756422","322083453","Trans 63 no 63 32 ");
        Cliente c7= new Cliente(7,"Javi","Hernandez","1037192921","3220834532","Cali");

        public RepositorioCliente()
        {
            listaClientes= new List<Cliente>{c1,c2,c3,c4,c5,c6,c7};
        }

        // public RepositorioCliente()
        // {
        //     listaClientes= new List<Cliente>(){
        //     new Cliente{Id=1,Nombres="Nestor",Apellidos="Quiroga",DocumentoIdentidad="10745577907",Telefono="3102095353"},
        //     new Cliente{Id=3,Nombres="Javi",Apellidos="Perez",DocumentoIdentidad="1074554227",Telefono="3113224242",Direccion="Cra 7D no 134 -5"}
        //     };
        // }

        //METODO PARA RETORNAR TODOS LOS CLIENTES DE LISTA
         public IEnumerable<Cliente> GetAllClientes()
         {
             return listaClientes;
         }

        //METODO PARA RETORNAR UN CLIENTE DESDE LISTA
        public Cliente GetCliente(int idCliente)
        {
            Cliente clienteEncontrado= listaClientes.FirstOrDefault(c =>c.Id==idCliente);
            return clienteEncontrado;  
        }

        //METODO PARA ACTUALIZAR UN CLIENTE DESDE LISTA
        public Cliente UpdateCliente(Cliente clienteActualizado)
        {
            Cliente clienteEncontrado= listaClientes.FirstOrDefault(c =>c.Id==clienteActualizado.Id);
            if(clienteEncontrado!=null)
            {   
                clienteEncontrado.Id= clienteEncontrado.Id;
                clienteEncontrado.Nombres= clienteActualizado.Nombres;
                clienteEncontrado.Apellidos= clienteActualizado.Apellidos;
                clienteEncontrado.DocumentoIdentidad= clienteActualizado.DocumentoIdentidad;
                clienteEncontrado.Telefono= clienteActualizado.Telefono;
                clienteEncontrado.Direccion= clienteActualizado.Direccion;
            }
            return clienteEncontrado;    
        }

        //METODO PARA CREAR UN CLIENTE DESDE LISTA

        public Cliente AddCliente(Cliente nuevoCliente){
            nuevoCliente.Id= listaClientes.Max(c => c.Id) +1;

            listaClientes.Add(nuevoCliente);
            return nuevoCliente;
        }

        //METODO PARA ELIMINAR CLIENTE
        public Cliente DeleteCliente(int idCliente)
        {
            Cliente clienteEncontrado= listaClientes.FirstOrDefault(c =>c.Id==idCliente);
            
            if (clienteEncontrado!=null){
                listaClientes.Remove(clienteEncontrado);
                
            }
            return clienteEncontrado;  
        }


        //private readonly AppContext _appContext;

        // public RepositorioCliente(AppContext appContext)
        // {
        //     _appContext= appContext;
        // }



        //METODO PARA AGREGAR UN CLIENTE
        // Cliente IRepositorioCliente.AddCliente(Cliente cliente){
        //     var clienteAdicionado= _appContext.Clientes.Add(cliente);
        //     _appContext.SaveChanges();
        //     return clienteAdicionado.Entity;
        // }

        //METODO PARA ELIMINAR CLIENTE
        // void IRepositorioCliente.DeleteCliente(int idCliente)
        // {
        //     var clienteEncontrado=_appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
        //     if (clienteEncontrado==null)
        //         return;
        //     _appContext.Clientes.Remove(clienteEncontrado);
        //     _appContext.SaveChanges();
        // }

        //METODO PARA RETORNAR TODOS LOS CLIENTES
        // IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        // {
        //     return _appContext.Clientes;
        // }

        //METODO PARA RETORNAR UN CLIENTE
        // Cliente IRepositorioCliente.GetCliente(int idCliente)
        // {
        //     var clienteEncontrado=_appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
        //     return clienteEncontrado;
           
        // }

        //METODO PARA ACTUALIZAR UN Cliente
        // Cliente IRepositorioCliente.UpdateCliente(Cliente Cliente, int idCliente)
        // {
        //     var clienteEncontrado=_appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
        //     if(clienteEncontrado!=null)
        //     {
        //         clienteEncontrado.Nombres= Cliente.Nombres;
        //         clienteEncontrado.Apellidos= Cliente.Apellidos;
        //         clienteEncontrado.DocumentoIdentidad= Cliente.DocumentoIdentidad;
        //         clienteEncontrado.Telefono= Cliente.Telefono;
        //         clienteEncontrado.Direccion= Cliente.Direccion;

        //         _appContext.SaveChanges();
                
        //     }
        //     return clienteEncontrado;
        // }


    }
}