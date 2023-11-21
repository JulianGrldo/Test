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
    [Route("/api/Assistants")]
    public class AssistantsController : ControllerBase
    {
        private readonly DataContext _context;

        public AssistantsController(DataContext context)
        {
            _context = context;
        }

        //Get con lista
        //Select * From Assistants

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Assistants.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var Assistant = await _context.Assistants.FirstOrDefaultAsync(x => x.Id == id);

            if (Assistant == null)
            {


                return NotFound();
            }

            return Ok(Assistant);


        }

        // Crear un nuevo registro
        [HttpPost]
        public async Task<ActionResult> Post(Assistant Assistant)
        {
            _context.Add(Assistant);
            await _context.SaveChangesAsync();
            return Ok(Assistant);
        }

        // Actualizar o cambiar registro

        [HttpPut]
        public async Task<ActionResult> Put(Assistant Assistant)
        {
            _context.Update(Assistant);
            await _context.SaveChangesAsync();
            return Ok(Assistant);
        }

        // ELiminar registros

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilaAfectada = await _context.Assistants
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






