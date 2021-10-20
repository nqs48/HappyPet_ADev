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

        //public static IRepositorioMascota _repoMascota= new RepositorioMascota(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World Veronica esta muy guapa!\n\n");

            // Cliente c1 = new Cliente(0,"Nestor","Quiroga Suarez","123456","310478474","Susa");

            // Mascota m1 = new Mascota(0,"Molly","Canino","Pinscher",c1.Id);

            // AgregarMascota(m1);

            
        }


  // private static Cliente AgregarCliente(Cliente c)
  //       {
  //           var clienteCreado= _repoCliente.AddCliente(c);
  //           //Console.WriteLine("El cliente ha sido creado: "+"\n\nId: "+c.Id+"\nCliente: "+c.Nombres+" "+c.Apellidos+"\nIdentificacion: "+c.DocumentoIdentidad+"\nTelefono: "+c.Telefono+"\n\n");
  //           return clienteCreado;
  //       }

  // private static Mascota AgregarMascota(Mascota m)
  //       {
  //           var mascotaCreada= _repoMascota.AddMascota(m);
  //           //Console.WriteLine("El cliente ha sido creado: "+"\n\nId: "+c.Id+"\nCliente: "+c.Nombres+" "+c.Apellidos+"\nIdentificacion: "+c.DocumentoIdentidad+"\nTelefono: "+c.Telefono+"\n\n");
  //           return mascotaCreada;
  //       }

    }
}
















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


        


        //IMPLEMENTACION DE METODOS CRUD

        //CREAR
        


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

    
