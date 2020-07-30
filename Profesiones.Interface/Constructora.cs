using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
    class Constructora
    {
        public Carpintero Carpintero { get; set; }
        public CarpinteroModerno CarpinteroModerno { get; set; }
        public string ContratarCarpintero()
        {
            Carpintero = new Carpintero();
            return "Contraté un carpintero";
        }

        public string ContratarCarpinteroModerno()
        {
            CarpinteroModerno = new CarpinteroModerno();
            return "Contraté un carpintero moderno";
        }
    }
}
