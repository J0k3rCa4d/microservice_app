using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data;
using Api.Dto;
using AutoMapper;

namespace Api.Services
{
    public class ExampleService : IExampleService
    {
        private readonly ApiDbContext context;
        private readonly IMapper mapper;
        private readonly ICalculatorService calculatorService;

        public ExampleService(ApiDbContext context, IMapper mapper, ICalculatorService calculatorService)
        {
            this.context = context;
            this.mapper = mapper;
            this.calculatorService = calculatorService;
        }

        public async Task AddAsync(IEnumerable<ExampleRequest> request)
        {
            var examples = mapper.Map<IEnumerable<Example>>(request);

            await context.Examples.AddRangeAsync(examples);
            await context.SaveChangesAsync();
        }

        public async Task<CalculationResponse> GetAsync(string example, long? from, long? to)
        {
            return await calculatorService.GetAsync(example, from, to);
        }
    }
}