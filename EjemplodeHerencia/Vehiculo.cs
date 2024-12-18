namespace HerenciaInterface.EjemplodeHerencia
{
    public class Vehiculo
    {
        
        //protected string Marca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string patente { get; set; }
        public string Combustible { get; set; }

        public Vehiculo()
        {
            //this.Color = "Rojo";
            //this.Color = color;
            //this.Marca = marca;

        }
        //public string devolverMarca()
        //{

        //    return this.Marca;
        //}


        // Metodos funcionalidad
        public virtual string Acelerar()
        {
            
            return "El vehiculo esta acelerando";
        }

        public virtual string Frenar()
        {
            return "El vehiculo esta frenando";
        }
        //public string devolverColor()
        //{
        //    return this.Color;
        //}

    }
}
