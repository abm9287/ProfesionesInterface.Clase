using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
    class Constructora
    {
        public ICarpintero Carpintero { get; set; }
        public string ContratarCarpintero(ICarpintero carpintero)
        {
            Carpintero = carpintero;
            return "Contrate un carpintero";
        }
        public string CosntruirMesa()
        {
            return Carpintero.Medir() + "Mesa"+ Carpintero.Diseñar()+"mesa"+ Carpintero.Serruchar() + "mesa"+ Carpintero.Lijar() + "mesa"+ Carpintero.Lijar() + "mesa"+ Carpintero.Lacar() + "mesa";
        }
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
