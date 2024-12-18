

namespace HerenciaInterface.EjemplodeHerencia
{

    
    public class Moto : Vehiculo
    {
 

    //    public string TipodeMoto { get; set; }

        public override string Acelerar()
        {

            return "La Moto esta acelerando";
        }

        public override string Frenar()
        {
            return "La Moto esta frenando";
        }
    }
}
