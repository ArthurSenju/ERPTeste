using ERPTeste.App_Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPTeste.Models
{
    [Table("Colaborador")]
    public class Colaborador 
    {
        [Column]
        public string Id { get; set; }
        [Column]
        public string Nome { get; set; }
        [Column]
        public string Cracha { get; set; }
        [Column]
        public string Setor { get; set; }
        [Column]
        public string Funcao { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public int CEP  { get; set; }
        [Column]
        public string Rua { get; set; }
        [Column]
        public int RG { get; set; }
        [Column]
        public int CPF { get; set; }
        [Column]
        public string CTPS { get; set; }
        [Column]
        public int Telefone { get; set; }
    }
}
