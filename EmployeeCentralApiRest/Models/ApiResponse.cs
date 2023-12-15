namespace EmployeeCentralApiRest.Models
{
    /// <summary>
    /// Clase genérica para encapsular respuestas API.
    /// </summary>
    /// <typeparam name="T">Tipo de datos de la carga útil de la respuesta.</typeparam>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Indica si la respuesta es exitosa.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Mensaje descriptivo asociado con la respuesta.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Lista de errores, si los hay.
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// Código de estado HTTP de la respuesta.
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Datos contenidos en la respuesta.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Constructor para crear una instancia de ApiResponse.
        /// </summary>
        /// <param name="data">Los datos de la respuesta.</param>
        /// <param name="message">Mensaje descriptivo.</param>
        /// <param name="statusCode">Código de estado HTTP.</param>
        /// <param name="errors">Lista de errores.</param>
        public ApiResponse(T? data = default(T), string message = "", int statusCode = 200, List<string>? errors = null)
        {
            Success = errors == null || !errors.Any();
            Data = data;
            Message = message;
            StatusCode = statusCode;
            Errors = errors ?? new List<string>();
        }

        /// <summary>
        /// Crea una respuesta exitosa.
        /// </summary>
        /// <param name="data">Los datos de la respuesta.</param>
        /// <param name="message">Mensaje descriptivo.</param>
        /// <returns>Una instancia de ApiResponse que representa una operación exitosa.</returns>
        public static ApiResponse<T> CreateSuccess(T data, string message = "")
        {
            return new ApiResponse<T>
            {
                Success = true,
                Data = data,
                Message = message,
                StatusCode = 200,
                Errors = new List<string>()
            };
        }

        /// <summary>
        /// Crea una respuesta con error.
        /// </summary>
        /// <param name="message">Mensaje descriptivo del error.</param>
        /// <param name="statusCode">Código de estado HTTP para el error.</param>
        /// <returns>Una instancia de ApiResponse que representa una operación fallida.</returns>
        public static ApiResponse<T> CreateError(string message, int statusCode)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Data = default(T),
                Message = message,
                StatusCode = statusCode,
                Errors = new List<string>() { message }
            };
        }
    }

}
