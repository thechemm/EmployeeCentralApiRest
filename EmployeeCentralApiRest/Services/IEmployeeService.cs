using EmployeeCentralApiRest.Models;
using EmployeeCentralApiRest.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCentralApiRest.Services
{
    
        public interface IEmployeeService
        {
            /// <summary>
            /// Obtiene una lista de todos los empleados.
            /// </summary>
            /// <returns>Una colección de empleados como <see cref="EmployeeDto"/>.</returns>
            public Task<IEnumerable<EmployeeDto>> GetEmployees();

            /// <summary>
            /// Obtiene un empleado específico por su ID.
            /// </summary>
            /// <param name="id">El ID del empleado a buscar.</param>
            /// <returns>
            /// El empleado como <see cref="EmployeeDto"/> si se encuentra; de lo contrario, null.
            /// </returns>
            public Task<EmployeeDto?> GetEmployee(int id);

            /// <summary>
            /// Actualiza la información de un empleado existente.
            /// </summary>
            /// <param name="id">El ID del empleado a actualizar.</param>
            /// <param name="employee">Los datos actualizados del empleado como <see cref="EmployeeDto"/>.</param>
            /// <returns>Una tarea que representa la operación asíncrona.</returns>
            public Task UpdateEmployee(int id, EmployeeDto employee);

            /// <summary>
            /// Agrega un nuevo empleado a la base de datos.
            /// </summary>
            /// <param name="employee">Los datos del empleado a agregar como <see cref="EmployeeDto"/>.</param>
            /// <returns>Una tarea que representa la operación asíncrona, devolviendo el empleado agregado como <see cref="EmployeeDto"/>.</returns>
            public Task<EmployeeDto> AddEmployee(EmployeeDto employee);

            /// <summary>
            /// Elimina un empleado específico por su ID.
            /// </summary>
            /// <param name="id">El ID del empleado a eliminar.</param>
            /// <returns>Una tarea que representa la operación asíncrona.</returns>
            public Task DeleteEmployee(int id);
        }

}
