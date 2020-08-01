using System;
using Profesiones.Implementacion;
using Profesiones.Negocio;
using Profesiones.AccesoDatos;
using Profesiones.Entidad;

namespace Profesiones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Constructora MiConstructora = new Constructora();

            MiConstructora.ContratarCarpintero(new CarpinteroEstandar());
            MiConstructora.ConstruirMesa();

            var carpintero1 = new CarpinteroModerno();
            carpintero1.Id = 10;
            MiConstructora.ContratarCarpintero(new CarpinteroModerno());

            var carpintero = new CarpinteroMusical();
            carpintero.Id = 10;

            MiConstructora.ConstruirMesa();
            MiConstructora.ContratarCarpintero(carpintero);
            MiConstructora.ConstruirMesa();

            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            applicationDbContext.Carpinteros.Add(new Carpintero());
            applicationDbContext.SaveChanges();
            Console.ReadKey();
        }
    }
}
