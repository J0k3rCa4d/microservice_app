using System.Threading.Tasks;
using Api.Dto;
using Refit;

namespace Api.Services
{
    public interface ICalculatorService
    {
        [Get("/calculations/{example}")]
        Task<CalculationResponse> GetAsync(string example, [AliasAs("from")]long? from = null, [AliasAs("to")]long? to = null);
    }
}