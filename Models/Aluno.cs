namespace ProjetoAlunoTurma.API.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TurmaId { get; set; }
        public Turma? Turma { get; set; }
        public string? Cpf { get; set; }
    }
}
