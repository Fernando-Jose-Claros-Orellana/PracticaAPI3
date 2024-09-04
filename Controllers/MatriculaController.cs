using FJCO20240904.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FJCO20240904.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MatriculaController : ControllerBase
    {
        static List<Matricula> matriculas = new List<Matricula>();
        // GET: api/<Matricula>
        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return matriculas;
        }

        // GET api/<Matricula>/5
        [HttpGet("{id}")]
        public Matricula Get(int id)
        {
            var matricula = matriculas.FirstOrDefault(c => c.Id == id);
            return matricula;
        }

        // POST api/<Matricula>
        [HttpPost]
        public IActionResult Post([FromBody] Matricula matricula)
        {
            matriculas.Add(matricula);
            return Ok();
        }

        // PUT api/<Matricula>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Matricula matricula)
        {
            var matriculaToUpdate = matriculas.FirstOrDefault(c => c.Id == id);
            if (matriculaToUpdate != null)
            {
                matriculaToUpdate.NombreEstudiante = matricula.NombreEstudiante;
                matriculaToUpdate.Especialidad = matricula.Especialidad;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<Matricula>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var matriculaToDelete = matriculas.FirstOrDefault(c => c.Id == id);
            if (matriculaToDelete != null)
            {
                matriculas.Remove(matriculaToDelete);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
