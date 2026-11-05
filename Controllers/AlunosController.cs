using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAlunoTurma.API.Data;
using ProjetoAlunoTurma.API.Models;

namespace ProjetoAlunoTurma.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task <IActionResult> CriarAluno (Aluno aluno)
        {
            var AlunoNovo = new Aluno 
            {
            Nome = aluno.Nome,
            TurmaId = aluno.TurmaId,
            DataCriacao = DateTime.Now
            };
            _context.Alunos.Add(AlunoNovo);
            await _context.SaveChangesAsync();

            return Ok("Aluno criado com sucesso!");
        }
        [HttpGet]
        public async Task <ActionResult<IEnumerable<AlunoTurma>>>
            GetAlunosTurma()
        {
            var Listar 
        }
    }
}
