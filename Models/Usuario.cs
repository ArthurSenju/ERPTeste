using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPTeste.Models
{
    
    [Table("Usuario")]
    public class Usuario
    {
        [Column]
        [Key]
        public int Id { get; set; }
        [Column]
        public string Nome { get; set; }
        [Column]
        public string Login { get; set; }
        [Column]
        public string Senha { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public int IdUsuarioInclusao { get; set; }
        [Column]
        public DateTime DataInclusao { get; set; }
        [Column]
        [ForeignKey("Colaborador")]
        public int IdColaborador { get; set; }
        [Column]
        public DateTime? DataExclusao { get; set; }
        [Column]
        public bool Ativo { get; set; }
        public Colaborador Colaborador { get; set; }




    }
}
