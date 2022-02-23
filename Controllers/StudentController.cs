using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet5.Dtos.Student;
using dotnet5.Models;
using dotnet5.Services.StudentService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<ServiceResponse<GetStudentDto>>> Get(int id) {
           return Ok(await _studentService.GetStudent(id));
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<Student>>> GetAll() {
            return Ok(await _studentService.GetStudents());
        }


        [HttpPost]

        public async Task<ActionResult<ServiceResponse<GetStudentDto>>> AddStudent(AddStudentDto AddStudent){
            return Ok(await _studentService.AddStudent(AddStudent));
        }


        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetStudentDto>>> UpdateStudent(UpdateStudentDto updateStudent) {
            var response = await _studentService.UpdateStudent(updateStudent);
            if(response.Data == null) {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> DeleteStudent(int id) {
            

            var response = await _studentService.DeleteStudent(id);
            if(response.Data == null) {
                return BadRequest(response);
            }
            return Ok(response);
            
        }









        
    }
}