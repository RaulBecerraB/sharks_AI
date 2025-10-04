using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sharks.Models
{
    public class Shark
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(20)]
        public string TagId { get; set; } = string.Empty; // ID del dispositivo de rastreo

        public string Gender { get; set; } = string.Empty; // Male, Female, Unknown

        public double Length { get; set; } // en metros
        public double Weight { get; set; } // en kilogramos

        public DateTime TaggedDate { get; set; } // Fecha cuando fue etiquetado
        public string TaggedLocation { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Notes { get; set; } = string.Empty;

        // Relación con especie
        public int SharkSpeciesId { get; set; }

        [ForeignKey("SharkSpeciesId")]
        public virtual SharkSpecies Species { get; set; } = null!;

        // Relación con datos de rastreo
        public virtual ICollection<SharkTracking> TrackingData { get; set; } = new List<SharkTracking>();
    }
}
