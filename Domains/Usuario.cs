using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique=true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do Usuário obrigatório!")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha obrigatória!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Senha deve conter de 6 á 20 caractéres!")]
        public string? Senha { get; set; }


        [Required(ErrorMessage = "Informe o tipo desse usuário!")]
        public Guid IdTipoDeUsuario { get; set; }
        //instancia a propriedade do tipo estudio para fazer a referencia com a foreignKey de IdTipoDeUsuario
        [ForeignKey("IdTipoDeUsuario")]
        public TiposDeUsuario? TipoDeUsuario { get; set; }
    }
}
