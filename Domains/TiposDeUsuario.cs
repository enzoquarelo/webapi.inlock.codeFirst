using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    [Table("TiposDeUsuario")]
    public class TiposDeUsuario
    {
        [Key]
        public Guid IdTipoDeUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do Tipo de Usuario obrigatória!")]
        public string? Titulo { get; set; }
    }
}
