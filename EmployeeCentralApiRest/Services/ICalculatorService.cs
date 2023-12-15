namespace EmployeeCentralApiRest.Services
{
    /// <summary>
    /// Interfaz para definir servicios de cálculo.
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// Calcula el porcentaje de un número.
        /// </summary>
        /// <param name="number">El número base sobre el cual se calculará el porcentaje.</param>
        /// <param name="percentage">El porcentaje a calcular del número base.</param>
        /// <returns>El resultado del cálculo del porcentaje.</returns>
        /// <example>
        /// Por ejemplo, si number es 100 y percentage es 20, el método devolverá 20, que es el 20% de 100.
        /// </example>
        double CalculatePercentage(double number, double percentage);

    }
}
