namespace HerenciaInterface.EjemplodeInterfaz
{
    public interface IAnimal
    {
        public string EmitirSonido();
        public string Comer();

        public string ObtenerDistancia()
        {
            return "El animal recorrió 5Km";
        }

    }
}
