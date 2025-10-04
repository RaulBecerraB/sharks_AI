namespace sharks.DTOs
{
    public class SharkSpeciesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ScientificName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double AverageLength { get; set; }
        public double AverageWeight { get; set; }
        public string Habitat { get; set; } = string.Empty;
        public string DangerLevel { get; set; } = string.Empty;
        public string ConservationStatus { get; set; } = string.Empty;
    }
}
