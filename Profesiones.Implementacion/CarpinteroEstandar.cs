using System.Collections.Generic;
using Profesiones.Interface;

namespace Profesiones.Implementacion
{
    /*los dos puntos puntos tienen dos significados:
        1. Implementacion: La clase pública Carpintero está implemetando la interfaz ICarpintero, relación de implementación
        2. Interfaz
     */
    public class CarpinteroEstandar : ICarpintero
    {
        private List<string> materialesParaClavar;//Ejemplo: clavo, tachuela => materiales para la construcción 'se usa un sustantivo' no clavar => MaterialParaClavar
        private string nombre;//Ejemplo: Juan.

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesParaCLavar { get { return materialesParaClavar; } set { materialesParaClavar = value; } }

        public string Diseñar()
        {
            return "Estoy diseñando";
        }
        public string Medir()
        {
            return "Estoy midiendo con metro";
        }
        public string Serruchar()
        {
            return "Estoy serruchando";
        }
        public string Clavar()
        {
            return "Estoy clavando";
        }
        public string Lijar()
        {
            return "Estoy lijando";
        }
        public string Lacar()
        {
            return "Estoy lacando";
        }
    }
}
