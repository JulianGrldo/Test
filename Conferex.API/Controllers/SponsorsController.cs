using Conferex.API.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Conferex.Shared.Entities;

namespace Conferex.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [ApiController]
    [Route("/api/Sponsors")]
    public class SponsorsController : ControllerBase
    {
        private readonly DataContext _context;

        public SponsorsController(DataContext context)
        {
            _context = context;
        }

        //Get con lista
        //Select * From Sponsors

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Sponsors.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var Sponsor = await _context.Sponsors.FirstOrDefaultAsync(x => x.Id == id);

            if (Sponsor == null)
            {


                return NotFound();
            }

            return Ok(Sponsor);


        }

        // Crear un nuevo registro
        [HttpPost]
        public async Task<ActionResult> Post(Sponsor Sponsor)
        {
            _context.Add(Sponsor);
            await _context.SaveChangesAsync();
            return Ok(Sponsor);
        }

        // Actualizar o cambiar registro

        [HttpPut]
        public async Task<ActionResult> Put(Sponsor Sponsor)
        {
            _context.Update(Sponsor);
            await _context.SaveChangesAsync();
            return Ok(Sponsor);
        }

        // ELiminar registros

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilaAfectada = await _context.Sponsors
                .Where(x => x.Id == id)//5
                .ExecuteDeleteAsync();

            if (FilaAfectada == 0)
            {


                return NotFound();//404
            }

            return NoContent();//204


        }


    }
}






