
using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
       private static IRepositorioDueno _repoDueno= new RepositorioDueno(new Persistencia.AppContext());
       private static IRepositorioVeterinario _repoVeterinario= new RepositorioVeterinario(new Persistencia.AppContext());
       private static IRepositorioMascota _repoMascota= new RepositorioMascota(new Persistencia.AppContext());
       //private static IRepositorioHistoria _repoHistoria= new RepositorioHistoria(new Persistencia.AppContext());
       private static IRepositorioVisitaPyP _repoVisitaPyP= new RepositorioVisitaPyP(new Persistencia.AppContext());



        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos, vamos a empezar a trabajar con las tablas");

            ListarDuenoFiltro();
            //AddDueno();
            //BuscarDueno();

            //ListarMascotaFiltro();
            //AddMascota();
            //BuscarMascota();

            //ListarVeterinarioFiltro();
            //AddVeterinario();
            //BuscarVererinario();

            //ListarHistoriaFiltro();
            //AddHistoria();
            //BuscarHistoria();

            //ListarVisitaPyPFiltro();
            //AddVisitaPyP();
            //BuscarVisitaPyP();

        }
        

        private static void AddDueno()
        {
           var dueno = new Dueno
            {
                Nombre = "Rosa",
                Apellidos = "Pacheco", 
                Direccion = "Cra 106 # 70",
                Telefono = "3009871122",
                Correo = "123@gmail.com"
            };
            _repoDueno.AddDueno(dueno);

        }

        private static void AddDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombre+ " " + dueno.Apellidos+ " " + dueno.Direccion+ " " + dueno.Telefono+ " " +dueno.Correo);

        }


        private static void AddVeterinario()
        {
           var veterinario = new Veterinario
            {
                Nombre = "Fabio",
                Apellidos = "Gonzales", 
                Direccion = "Cll 7 # 116",
                Telefono = "301667722",
                TarjetaProfesional = "Activo"
            };
            _repoVeterinario.AddVeterinario(veterinario);

        }

        private static void AddVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombre+ " " + veterinario.Apellidos+ " " + veterinario.Direccion+ " " + veterinario.Telefono+ " " +veterinario.TarjetaProfesional);

        }


        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Aurelio",
                Color = "Gris", 
                Especie = "Felino",
                Raza = "Criollo",
            };
            _repoMascota.AddMascota(mascota);
        }


        private static void AddMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre+ " " + mascota.Color+ " " + mascota.Especie+ " " + mascota.Raza+ " ");

        }
        
    }
}
