namespace HerenciaInterface.EjemploClaseAbstracta
{
    public abstract class Animal
    {

        public string raza { get; set; }
        public Animal()
        {

        }

        public abstract string Comer();

        public string ObtenerDistancia()
        {
            return "El animal recorrió 5Km";
        }
        
    }
}
