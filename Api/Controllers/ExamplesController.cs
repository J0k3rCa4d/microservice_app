using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Dto;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly IExampleService exampleService;

        public ApiController(IExampleService exampleService)
        {
            this.exampleService = exampleService;
        }

        [HttpGet("{example}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CalculationResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Query(string example, [FromQuery]long? from = null, [FromQuery]long? to = null)
        {
            var result = await exampleService.GetAsync(example, from, to);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add([FromBody] IEnumerable<ExampleRequest> request)
        {
            if(request != null)
            {
                 await exampleService.AddAsync(request);
                 return Created("", null);
            }   

            return BadRequest();
        }
    }
}