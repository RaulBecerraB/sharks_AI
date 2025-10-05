using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharks.Models
{
    public class SharkTracking
    {
        [Key]
        public int Id { get; set; }

        public int SharkId { get; set; }

        [Column(TypeName = "decimal(10, 8)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(11, 8)")]
        public decimal Longitude { get; set; }

        public DateTime TrackingDateTime { get; set; }

        [Column(TypeName = "decimal(10, 7)")]
        public decimal ChlorA { get; set; }

        // Relación con el tiburón
        [ForeignKey("SharkId")]
        public virtual Shark Shark { get; set; } = null!;
    }
}
