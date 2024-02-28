using System.Text.Json.Serialization;

namespace MathCalculatorApi.Responses;

public record BasicArithmeticResponse
{
    [JsonPropertyName("numbers")]
    public ICollection<int> Numbers { get; }
    [JsonPropertyName("result")]
    public int Result { get; }

    public BasicArithmeticResponse(int result, ICollection<int> numbers)
    {
        Numbers = numbers;
        Result = result;
    }

    public BasicArithmeticResponse(int result, params int[] numbers)
    {
        Result = result;
        Numbers = numbers;
    }
}