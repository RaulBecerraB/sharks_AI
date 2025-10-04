using System.ComponentModel.DataAnnotations;

namespace sharks.Models
{
    public class SharkSpecies
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string ScientificName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        // Propiedades específicas de la especie
        public double AverageLength { get; set; } // en metros
        public double AverageWeight { get; set; } // en kilogramos
        public string Habitat { get; set; } = string.Empty;
        public string DangerLevel { get; set; } = string.Empty; // Low, Medium, High
        public string ConservationStatus { get; set; } = string.Empty; // Endangered, Vulnerable, etc.

        // Relación con tiburones
        public virtual ICollection<Shark> Sharks { get; set; } = new List<Shark>();
    }
}
