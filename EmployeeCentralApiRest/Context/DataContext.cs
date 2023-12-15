using EmployeeCentralApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCentralApiRest.Context
{
    /// <summary>
    /// Contexto de base de datos para la aplicación Employee Central.
    /// Extiende DbContext de Entity Framework Core.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Constructor de DataContext que toma opciones de DbContext.
        /// </summary>
        /// <param name="options">Opciones de configuración para el contexto.</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // El constructor llama al constructor base de DbContext con las opciones proporcionadas.
        }

        /// <summary>
        /// DbSet que representa la colección de empleados en la base de datos.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
    }

}
