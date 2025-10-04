namespace sharks.DTOs
{
    public class SharkTrackingDto
    {
        public int Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime TrackingDateTime { get; set; }
    }
}
