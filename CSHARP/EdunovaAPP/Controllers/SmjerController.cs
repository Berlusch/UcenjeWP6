using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        private readonly EdunovaContext _context;

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Smjerovi);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }

        }
        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {
            try
            {
                var s = _context.Smjerovi.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                return Ok(s);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {

            try
            {
                _context.Smjerovi.Add(smjer);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, smjer);



            }
            catch (Exception e)
            {

                return BadRequest(e);
            }




        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]  
        public IActionResult Put(int sifra, Smjer smjer)

        {
            try
            {

                var s =_context.Smjerovi.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                //rucno mapiranje, kasnije automaper
                s.Naziv = smjer.Naziv;
                s.CijenaSmjera = smjer.CijenaSmjera;
                s.IzvodiSeOd = smjer.IzvodiSeOd;
                s.Vaucer = smjer.Vaucer;
                _context.Smjerovi.Update(s);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno ažurirano" });
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }

        }

        [HttpDelete]
        [Route("{sifra:int}")]
        public IActionResult Delete(int sifra)
        {
            try
            {
                var s = _context.Smjerovi.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                _context.Smjerovi.Remove(s);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno obrisano" });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }



    }
}
