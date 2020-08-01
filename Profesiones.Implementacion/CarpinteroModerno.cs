using System.Collections.Generic;
using Profesiones.Interface;

namespace Profesiones.Implementacion
{
   
    public class CarpinteroModerno : ICarpintero
    {
        private List<string> materialesParaClavar;//Ejemplo: clavo, tachuela => materiales para la construcción 'se usa un sustantivo' no clavar => MaterialParaClavar
        private string nombre;//Ejemplo: Juan.

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesParaCLavar { get { return materialesParaClavar; } set { materialesParaClavar = value; } }


        public string Diseñar()
        {
            return "Estoy diseñando con AutoCad";
        }
        public string Medir()
        {
            return "Estoy midiendo con láser";
        }
        public string Serruchar()
        {
            return "Estoy serruchando con máquina";
        }
        public string Clavar()
        {
            return "Estoy clavando con pistola de aire comprimido";
        }
        public string Lijar()
        {
            return "Estoy lijando con lijadora con absorción";
        }
        public string Lacar()
        {
            return "Estoy lacando de secado instantáneo";
        }
    }
}
