using EmployeeCentralApiRest.Models;
using EmployeeCentralApiRest.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCentralApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PercentageController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public PercentageController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpGet]
        public IActionResult CalculatePercentage(double number, double percentage)
        {
            if (double.TryParse(number.ToString(), out double num) && double.TryParse(percentage.ToString(), out double perc))
            {
                double result = _calculatorService.CalculatePercentage(num, perc);
                return Ok(new ApiResponse<object>(new { Number = num, Percentage = perc, Result = result }, "Cálculo realizado con éxito"));
            }
            else
            {
                return BadRequest(new ApiResponse<object>(null, "Entradas inválidas. Asegúrese de que 'number' y 'percentage' sean números.", 400));
            }
        }
    }
}
