using EmployeeCentralApiRest.Models;
using EmployeeCentralApiRest.Models.DTO;
using EmployeeCentralApiRest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeCentralApiRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employees = await _employeeService.GetEmployees();
                return Ok(new ApiResponse<IEnumerable<EmployeeDto>>(employees, "Empleados obtenidos con éxito."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<IEnumerable<EmployeeDto>>(null, ex.Message, 500));
            }
        }

        
        // GET: api/Employee/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            try
            {
                var employee = await _employeeService.GetEmployee(id);
                if (employee == null)
                {
                    return NotFound(new ApiResponse<EmployeeDto>(null, "Empleado no encontrado.", 404));
                }

                return Ok(new ApiResponse<EmployeeDto>(employee, "Empleado encontrado con éxito."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<EmployeeDto>(null, ex.Message, 500));
            }
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] EmployeeDto employeeDto)
        {
            try
            {
                var createdEmployeeDto = await _employeeService.AddEmployee(employeeDto);

                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployeeDto.EmployeeId }, new ApiResponse<EmployeeDto>(createdEmployeeDto, "Empleado creado con éxito."));
            }
            catch (Exception ex)
            {
                //  ApiResponse también es del tipo DTO.
                return StatusCode(500, new ApiResponse<EmployeeDto>(null, ex.Message, 500));
            }
        }

        // PUT: api/Employee/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody]  EmployeeDto employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest(new ApiResponse<Employee>(null, "El ID del empleado no coincide con el ID en la URL.", 400));
            }

            try
            {
                await _employeeService.UpdateEmployee(id, employee);
                return Ok(new ApiResponse<EmployeeDto>(employee, "Empleado actualizado con éxito."));
            }
            catch (KeyNotFoundException knfEx)
            {
                return NotFound(new ApiResponse<EmployeeDto>(null, knfEx.Message, 404));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<EmployeeDto>(null, ex.Message, 500));
            }
        }

        // DELETE: api/Employee/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                await _employeeService.DeleteEmployee(id);
                return Ok(new ApiResponse<EmployeeDto>(null, "Empleado eliminado con éxito."));
            }
            catch (KeyNotFoundException knfEx)
            {
                return NotFound(new ApiResponse<EmployeeDto>(null, knfEx.Message, 404));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<EmployeeDto>(null, ex.Message, 500));
            }
        }
    }
}
