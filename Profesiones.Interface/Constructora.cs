using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
    class Constructora
    {
        public ICarpintero Carpintero { get; set; }
        public string ContratarCarpintero()
        {
            Carpintero = new Carpintero();
            return "Contraté un carpintero";
        }

        public string ContratarCarpinteroModerno()
        {
            Carpintero = new CarpinteroModerno();
            return "Contraté un carpintero moderno";
        }

        public string ContratarOtroCarpintero()
        {
            Carpintero = new CarpinteroMusical();
            return "Contrate un carpintero musical";
        }
    }
}
