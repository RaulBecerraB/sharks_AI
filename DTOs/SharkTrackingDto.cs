namespace sharks.DTOs
{
    public class SharkTrackingDto
    {
        public int Id { get; set; }
        public int SharkId { get; set; }
        public string SharkName { get; set; } = string.Empty;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime TrackingDateTime { get; set; }
        public decimal ChlorA { get; set; }
    }
}
