using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
    public class CarpinteroMusical : ICarpintero
    {
        public string Clavar()
        {
            return "Estoy clavando y escuchando Trap";
        }

        public string Diseñar()
        {
            return "Estoy diseñando y clavando";
        }

        public string Lacar()
        {
            return "Estoy lancando y bailando";
        }

        public string Lijar()
        {
            return "Estoy lijando y piropeando";
        }

        public string Medir()
        {
            return "Estoy midiendo mientras silbo";
        }

        public string Serruchar()
        {
            return "Estoy serruchando con música ";
        }
    }
}
