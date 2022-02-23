using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet5.Dtos.Student;
using dotnet5.Models;

namespace dotnet5.Services.StudentService
{
    public interface IStudentService
    {
         Task<ServiceResponse<GetStudentDto>> GetStudent(int id);

         Task<ServiceResponse<List<GetStudentDto>>> GetStudents();

         Task<ServiceResponse<List<GetStudentDto>>> DeleteStudent(int id);

         Task<ServiceResponse<GetStudentDto>> UpdateStudent(UpdateStudentDto updatedStudent);

         Task<ServiceResponse<List<GetStudentDto>>> AddStudent(AddStudentDto AddStudent);
         
         

        
    }
}