using dotnet5.Models;

namespace dotnet5.Dtos.Student
{
    public class UpdateStudentDto
    {
        public int Id { get; set; } 

        public string Name {get; set;} 

        public int Age { get; set; }
        public StudentClass Class {get; set;}
    }
}