using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogos { get; set; } = Guid.NewGuid();



        [Required(ErrorMessage = "Informe o estúdio que criou o jogo!")]
        public Guid IdEstudio { get; set; }
        //instancia a propriedade do tipo estudio para fazer a referencia com a foreignKey de IdEstudio
        [ForeignKey("IdEstudio")]
        public Estudio Estudio { get; set; }



        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do jogo obrigatório!")]
        public string Nome { get; set; } = null!;

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do jogo obrigatória!")]
        public string Descrição { get; set; } = null!;

        [Column(TypeName = "Date")]
        [Required(ErrorMessage = "Data de Lançamento do jogo obrigatória!")]
        public DateTime DataLançamento { get; set; }

        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "Preço do jogo obrigatório!")]
        public decimal Valor { get; set; }

        public virtual Estudio? IdEstudioNavigation { get; set; }
    }
}
