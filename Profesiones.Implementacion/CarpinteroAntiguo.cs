using System.Collections.Generic;
using Profesiones.Interface; 

namespace Profesiones.Implementacion
{
    public class CarpinteroAntiguo : ICarpintero
    {
        //Utilizamos sustantivos para definir atributos 
        private List<string> materialesParaClavar;//Ejemplo: clavo, tachuela => materiales para la construcción 'se usa un sustantivo' no clavar => MaterialParaClavar
        private string nombre;//Ejemplo: Juan.

        public string Nombre { get { return nombre;  } set { nombre = value; } }
        public List<string> MaterialesParaCLavar { get { return materialesParaClavar; } set { materialesParaClavar = value; } }
     

        
        //métodos utilizamos verbos para los nombres de los métodos
        public string Clavar()
        {
            return $"Mi nombre es: {nombre} y estoy clavando {materialesParaClavar[0]}";
        }
        public string Diseñar()
        {
            return "Estoy diseñando con AutoCad y cantando";
        }

        public string Lacar()
        {
            return "Estoy lancando y excuchando MetalDeath";
        }

        public string Lijar()
        {
            return "Estoy lijandoy bailando 90' music";
        }

        public string Medir()
        {
            return "Estoy midiendo mientras excucho música de los 80 ";
        }

        public string Serruchar()
        {
            return "Estoy serruchando 2 horas";
        }

    }
}
