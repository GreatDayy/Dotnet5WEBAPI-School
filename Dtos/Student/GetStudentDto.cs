using dotnet5.Models;

namespace dotnet5.Dtos.Student
{
    public class GetStudentDto
    {
        public int Id { get; set; } = 1;

        public string Name {get; set;} = "Arvid";

        public int Age { get; set; }
        public StudentClass Class {get; set;} = StudentClass.TE19D;
    }
}