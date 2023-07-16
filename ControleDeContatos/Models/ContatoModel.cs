using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        
        public string Nome { get; set; }
        [Display(Name = "Email")]
        [Column("Email")]
       
        public string Email { get; set; }
        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string Telefone { get; set; }
    }
}
