using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet5.Dtos.Student;
using dotnet5.Models;

namespace dotnet5.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private static List<Student> studentList = new List<Student>() {

            new Student(),
            new Student() {Id = 2, Name="Albin", Class=StudentClass.TE19C}
        };


        private readonly IMapper _mapper;
        public StudentService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetStudentDto>> GetStudent(int id)
        {
            //Hitta studenten --> FirstOrDefault
            var serviceResponse = new ServiceResponse<GetStudentDto>();
            var student =  studentList.FirstOrDefault(s => s.Id == id);
            serviceResponse.Data = _mapper.Map<GetStudentDto>(student);
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetStudentDto>>> GetStudents()
        {
            var serviceResponse = new ServiceResponse<List<GetStudentDto>>();
            serviceResponse.Data = studentList.Select(s => _mapper.Map<GetStudentDto>(s)).ToList();
            return serviceResponse;

        }

          public async Task<ServiceResponse<List<GetStudentDto>>> AddStudent(AddStudentDto AddStudent)
        {
            var serviceResponse = new ServiceResponse<List<GetStudentDto>>();
            var student = _mapper.Map<Student>(AddStudent);
            student.Id = studentList.Max(s => s.Id) + 1;
            studentList.Add(student);
            serviceResponse.Data = studentList.Select(s => _mapper.Map<GetStudentDto>(s)).ToList();
            return serviceResponse;
        }


        public async Task<ServiceResponse<GetStudentDto>> UpdateStudent(UpdateStudentDto updatedStudent)
        {
            var serviceResponse = new ServiceResponse<GetStudentDto>();
            var student = studentList.FirstOrDefault(s => s.Id == updatedStudent.Id);
            if (student == null)
            {
                serviceResponse.Message = $"No corresponding student with ID: ${updatedStudent.Id} were found";
                return serviceResponse;
            }
            // student.Name = updatedStudent.Name;
            // student.Class = updatedStudent.Class;
            serviceResponse.Data = _mapper.Map<GetStudentDto>(student);
            return serviceResponse;


        }
        public async Task<ServiceResponse<List<GetStudentDto>>> DeleteStudent(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetStudentDto>>();
            var student = studentList.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                serviceResponse.Message = $"Student with the ID: {id} Could Not Be Found";
                return serviceResponse;
            }
            //else remove the student save the list and 
            studentList.Remove(student);
            serviceResponse.Data = studentList.Select(s => _mapper.Map<GetStudentDto>(s)).ToList();
            return serviceResponse;
        }

      
    }
}