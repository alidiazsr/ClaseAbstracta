using HerenciaInterface.EjemploClaseAbstracta;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploClaseAbstractaController : Controller
    {

        [HttpGet]
        public string EjemploClaseAbstracta()
        {
           //Auto auto = new Auto("Toyota");
            //Vehiculo vehiculo = new Vehiculo();
            ////vehiculo.ObtenerDistanciaRecorrida();
             Moto moto = new Moto();
            //return auto.ObtenerDistanciaRecorrida();
            Perro perro = new Perro("Pastor Aleman");
            return perro.Comer() + " " + perro.ObtenerDistancia();

        }

    }
}
