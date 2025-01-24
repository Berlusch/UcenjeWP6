using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;

namespace WebAPI9.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController:ControllerBase
    {

        //počinje ruta -> 

        //ruta je metoda
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello world!";
        }


        //završava ruta


        //počinje ruta

        [HttpGet]
        [Route("helloworld")]
        public string HelloWorld(string ime)
        
        {
            return $"Hello {ime}!";
        }

        //završava ruta

        //---------------------------------------------------

        //počinje ruta


        [HttpGet]
        [Route("json")]
        public IActionResult Json(int sifra, string ime)
        {
            return Ok(new { Sifra = sifra, Ime = ime });
        }


        //završava ruta

        //--------------------------------------------------------
        //počinje ruta

        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(201, osoba);
        }


        //završava ruta

        //--------------------------------------------------

        //počinje ruta

        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }



        //završava ruta

        //---------------------------------------------------------------

        //počinje ruta

        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new {poruka="Šifra mora biti veća od 0!"});
            }
            return StatusCode(StatusCodes.Status204NoContent);
        }


        //završava ruta

        

    }
}
