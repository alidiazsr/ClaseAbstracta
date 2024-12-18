namespace HerenciaInterface.EjemploClaseAbstracta
{
    public class Perro: Animal
    {
        public Perro(string raza) : base(raza)
        {

        }
        public override string Comer()
        {
            return "El Perro esta Comiendo";
        }
    }
}
