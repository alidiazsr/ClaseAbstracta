namespace HerenciaInterface.EjemploClaseAbstracta
{
    public abstract class Vehiculo
    {
       // public string marca { get; set; }
      //  public Vehiculo(string marca)
      //  {


       // }


        public abstract string Acelerar();

        public string ObtenerDistanciaRecorrida()
        {
            return "El vehículo recorrió 20Km";
        }
    }
}
