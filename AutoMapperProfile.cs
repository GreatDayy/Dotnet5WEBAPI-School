using AutoMapper;
using dotnet5.Dtos.Student;
using dotnet5.Models;

namespace dotnet5
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, GetStudentDto>();
            CreateMap<AddStudentDto, Student>();
            
        }
    }
}