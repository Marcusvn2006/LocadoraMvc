using System.ComponentModel.DataAnnotations;

namespace LocadoraMVC.Models
{
    public class Patio
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
    }
}
