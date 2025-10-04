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

        // Datos adicionales que podrían ser útiles
        public double? Depth { get; set; } // Profundidad en metros
        public double? Temperature { get; set; } // Temperatura del agua en °C
        public double? Speed { get; set; } // Velocidad en km/h
        public string? SignalStrength { get; set; } // Fuerza de la señal

        [MaxLength(200)]
        public string? Notes { get; set; }

        // Relación con el tiburón
        [ForeignKey("SharkId")]
        public virtual Shark Shark { get; set; } = null!;
    }
}
