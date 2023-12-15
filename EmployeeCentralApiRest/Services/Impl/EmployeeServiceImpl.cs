using AutoMapper;
using EmployeeCentralApiRest.Context;
using EmployeeCentralApiRest.Models;
using EmployeeCentralApiRest.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeCentralApiRest.Services.Impl
{
    public class EmployeeServiceImpl : IEmployeeService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public EmployeeServiceImpl(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Devuelve una lista de empleados
        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
           var employees = await _context.Employees.ToListAsync();
            return _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        }

        // Devuelve un solo empleado o null si no se encuentra
        public async Task<EmployeeDto?> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return null;
            return _mapper.Map<EmployeeDto>(employee);
        }

        // Actualiza un empleado existente, asumiendo que 'employee' tiene la misma ID que 'id'.
        public async Task UpdateEmployee(int id, EmployeeDto employeeDto)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                throw new KeyNotFoundException("No se encontró el empleado con ID: " + id);

            _mapper.Map(employeeDto, employee);
            _context.Entry(employee).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        // Crea un nuevo empleado.
        public async Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return _mapper.Map<EmployeeDto>(employee);
        }

        // Elimina un empleado por ID.
        public async Task DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                throw new KeyNotFoundException("No se encontró el empleado con ID: " + id);

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

            // Verifica si un empleado existe.
            private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
