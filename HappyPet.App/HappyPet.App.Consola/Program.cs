// using System.Runtime.ExceptionServices;
// using System.ComponentModel;
// using System.Runtime.CompilerServices;

using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using HappyPet.App.Persistencia;
using HappyPet.App.Persistencia.AppRepositorios;

namespace HappyPet.App.Consola
{
    class Program
    {
        //public static IRepositorioCliente _repoCliente= new RepositorioCliente(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Veronica esta muy guapa!\n\n");

            // Cliente c= new Cliente{Nombres= "Jesus",
            // Apellidos="Benitez",
            // DocumentoIdentidad="1032849284",
            // Telefono="31049780983",
            // Direccion="Bogota"};

            // AgregarCliente(c);

            // Cliente c= new Cliente{Nombres= "William",
            // Apellidos="Beltran",
            // DocumentoIdentidad="10430972354",
            // Telefono="32358032853",
            // Direccion="Bogota"};
            // AgregarCliente(c);


            //BuscarCliente(1);


            // Cliente c= new Cliente{Nombres= "Nestor",
            // Apellidos="Quiroga",
            // DocumentoIdentidad="10743075353",
            // Telefono="3102095353",
            // Direccion="Barranquilla",
            // };
            //AgregarCliente(c);
            // ActualizarCliente(c,2);

            //ObtenerClientes();

            //EliminarCliente(6);


        }



        //IMPLEMENTACION DE METODOS CRUD

        //CREAR
        // private static void AgregarCliente(Cliente c)
        // {
        //     var cliente= new Cliente{
        //     Nombres= c.Nombres,
        //     Apellidos=c.Apellidos,
        //     DocumentoIdentidad=c.DocumentoIdentidad,
        //     Telefono=c.Telefono,
        //     Direccion=c.Direccion,
        //     };
        //     _repoCliente.AddCliente(cliente);
        //     Console.WriteLine("El cliente ha sido creado: "+"\n\nId: "+cliente.Id+"\nCliente: "+c.Nombres+" "+c.Apellidos+"\nIdentificacion: "+cliente.DocumentoIdentidad+"\nTelefono: "+cliente.Telefono+"\n\n");

        // }


        //BUSCAR
        // private static void BuscarCliente(int idCliente)
        // {
        //     var cliente= _repoCliente.GetCliente(idCliente);
        //     Console.WriteLine("Cliente encontrado: \n\n"+"ID: "+cliente.Id+"\nCliente: "+cliente.Nombres +" "+cliente.Apellidos+"\nIdentificacion: "+cliente.DocumentoIdentidad+"\nTelefono: "+cliente.Telefono+"\n\n");
        // }


        //ELIMINAR
        // private static void EliminarCliente(int idCliente)
        // {
        //     var cliente= _repoCliente.GetCliente(idCliente);
        //     _repoCliente.DeleteCliente(idCliente);
        //     Console.WriteLine("El cliente ha sido eliminado: \n\n"+"ID: "+cliente.Id+"\nCliente: "+cliente.Nombres +" "+cliente.Apellidos+"\nIdentificacion: "+cliente.DocumentoIdentidad+"\nTelefono: "+cliente.Telefono+"\n\n");
        // } 

        //ACTUALIZAR
        // private static void ActualizarCliente(Cliente cliente,int idCliente)
        // {
        //     _repoCliente.UpdateCliente(cliente,idCliente);
        //     Console.WriteLine("El cliente ha sido actualizado a: \n\nCliente: "+cliente.Nombres +" "+cliente.Apellidos+"\nIdentificacion: "+cliente.DocumentoIdentidad+"\nTelefono: "+cliente.Telefono+"\n\n");
        // }


        //OBTENER TODOS LOS CLIENTES
        // private static void ObtenerClientes()
        // {
        //     var lista =_repoCliente.GetAllClientes();

        //     Console.WriteLine("Clientes Actuales: \n");
        //     foreach (var i in lista)
        //     {
        //         Console.WriteLine("ID "+i.Id+"\nNombre: "+i.Nombres+"\nApellidos: "+i.Apellidos+"\nDireccion: "+i.Direccion+"\nTelefono: "+i.Telefono+"\n\n");
        //     }

        // }

    }
}
