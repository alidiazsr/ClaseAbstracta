namespace HerenciaInterface.EjemplodeHerencia
{

    
    public class Auto : Vehiculo
    {
       // public string NroChasis { get; set; }

        public override string Acelerar()
        {

            return "El Auto esta acelerando";
        }

        public override string Frenar()
        {
            //throw new System.NotImplementedException();
            return "El Auto esta frenando";
        }
    }
}
