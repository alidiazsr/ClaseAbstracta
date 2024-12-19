using HerenciaInterface.EjemploClaseAbstracta;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploClaseAbstractaController : ControllerBase
    {

        [HttpGet]
        [Route("api/EjemploClaseAbstracta")]
        public string EjemploClaseAbstracta()
        {
           //Auto auto = new Auto("Toyota");
            //Vehiculo vehiculo = new Vehiculo();
            ////vehiculo.ObtenerDistanciaRecorrida();
             Moto moto = new Moto();
            //return auto.ObtenerDistanciaRecorrida();
            Perro perro = new Perro();
            return perro.Comer() + " " + perro.ObtenerDistancia();

        }

    }
}
