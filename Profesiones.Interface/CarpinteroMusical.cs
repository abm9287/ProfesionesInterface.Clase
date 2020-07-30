using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
    public class CarpinteroMusical : ICarpintero
    {
        public string Diseñar()
        {
            return "Estoy diseñando con AutoCad Versión ";
        }
        public string Medir()
        {
            return "Estoy midiendo flexómetro";
        }
        public string Serruchar()
        {
            return "Estoy serruchando con máquina y escuchando música";
        }
        public string Clavar()
        {
            return "Estoy clavando clavos de acero con la pistola de aire comprimido";
        }
        public string Lijar()
        {
            return "Estoy lijando con lijadora con absoción y piropeando";
        }
        public string Lacar()
        {
            return "Estoy Estoy lacando con secado instanáneo y al mismo tiempo limpio la superficie de la pintura";
        }
    }
}
