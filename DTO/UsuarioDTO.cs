using ERPTeste.Models;

namespace ERPTeste.DTO
{
    public class UsuarioDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int idColaborador { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int IdUsuarioLogadoInclusao { get; set; }

    }
}
