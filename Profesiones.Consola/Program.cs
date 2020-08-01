using System;
using Profesiones.Implementacion;
using Profesiones.Negocio;


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
            MiConstructora.ContratarCarpintero(new CarpinteroModerno());
            MiConstructora.ConstruirMesa();
            MiConstructora.ContratarCarpintero(new CarpinteroMusical());
            MiConstructora.ConstruirMesa();

            Console.ReadKey();
        }
    }
}
