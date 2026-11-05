using Microsoft.AspNetCore.Mvc;
using ProjetoAlunoTurma.API.Data;

namespace ProjetoAlunoTurma.API.Controllers
{
    public class TurmasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TurmasController (AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CriarTurma (Turma turma)
        {
            
        }
    }
}
