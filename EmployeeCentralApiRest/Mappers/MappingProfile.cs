using AutoMapper;
using EmployeeCentralApiRest.Models.DTO;
using EmployeeCentralApiRest.Models;

namespace EmployeeCentralApiRest.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
