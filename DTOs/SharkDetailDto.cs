namespace sharks.DTOs
{
    public class SharkDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TagId { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public double Length { get; set; }
        public double Weight { get; set; }
        public DateTime TaggedDate { get; set; }
        public string TaggedLocation { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public SharkSpeciesDto Species { get; set; } = new();
        public List<SharkTrackingDto> TrackingHistory { get; set; } = new();
    }
}
