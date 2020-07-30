namespace Profesiones.Interface
{
    public class CarpinteroModerno : ICarpintero
    {
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
