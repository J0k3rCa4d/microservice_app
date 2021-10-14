using System.Text.Json.Serialization;

namespace Api.Dto
{
    public class CalculationResponse
    {
        public float Avg { get; set; }

        public int Sum { get; set; }
    }
}   