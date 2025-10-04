namespace sharks.DTOs
{
    public class SharkTrackingDto
    {
        public int Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime TrackingDateTime { get; set; }
        public double? Depth { get; set; }
        public double? Temperature { get; set; }
        public double? Speed { get; set; }
        public string? SignalStrength { get; set; }
        public string? Notes { get; set; }
    }
}
