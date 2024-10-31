using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraMVC.Models
{
    public class Locacao
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataLocacao { get; set; }
        public DateTime? DataDevolucao { get; set; }

        [ForeignKey("VeiculoId")]
        public Guid VeiculoId { get; set; }
        public Veiculo? Veiculo { get; set; }


        [ForeignKey("ClienteId")]
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
