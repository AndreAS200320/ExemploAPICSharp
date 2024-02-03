using ExemploAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]

        public Pessoa GetPessoa()
        {
            var vPessoa = new Pessoa();

            vPessoa.Id = 1;
            vPessoa.Nome = "José";
            vPessoa.Telefone = "(18)988180248";
            
            return vPessoa;
        }
    }
}
