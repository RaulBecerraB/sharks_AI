namespace sharks.DTOs
{
    public class PredictionRequestDto
    {
        public List<PositionDto> Positions { get; set; } = new List<PositionDto>();
    }

    public class PositionDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class PredictionResponseDto
    {
        public double Predicted_Latitude { get; set; }
        public double Predicted_Longitude { get; set; }
    }

    public class SharkPredictionResultDto
    {
        public int SharkId { get; set; }
        public string SharkName { get; set; } = string.Empty;
        public List<PredictedPositionDto> PredictedPositions { get; set; } = new List<PredictedPositionDto>();
        public List<PositionDto> UsedPositions { get; set; } = new List<PositionDto>();
    }

    public class PredictedPositionDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Iteration { get; set; }
        public DateTime PredictedFor { get; set; }
    }
}
