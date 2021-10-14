using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Dto;

namespace Api.Services
{
    public interface IExampleService
    {
        Task<CalculationResponse> GetAsync(string example, long? from, long? to);

        Task AddAsync(IEnumerable<ExampleRequest> examples);
    }
}