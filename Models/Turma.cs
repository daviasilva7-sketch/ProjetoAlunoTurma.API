namespace ProjetoAlunoTurma.API.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }
        public string Professor { get; set; }
        public DateTime DataCriacao { get; set; }
        public ICollection <Aluno> Alunos { get; set; }
    }
}