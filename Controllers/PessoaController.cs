using System.Threading.Tasks;
using apidotnet5.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apidotnet5.Models;

namespace apidotnet5.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private DataContext dc;

        public PessoaController(DataContext context)
        {
            this.dc = context;
        }

        [HttpPost("api")]
        public async Task<ActionResult> cadastrar([FromBody] Pessoa pessoa)
        {
            dc.pessoa.Add(pessoa);
            await dc.SaveChangesAsync();

            return Created("Objeto pessoa", pessoa);
        }

        [HttpGet("api")]
        public async Task<ActionResult> listar()
        {
            var dados = await dc.pessoa.ToListAsync();
            return Ok(dados);
        }
    }
}