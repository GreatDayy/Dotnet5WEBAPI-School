using dotnet5.Models;

namespace dotnet5.Dtos.Student
{
    public class AddStudentDto
    {
        public string Name { get; set; } = "Arvid";

        public int Age { get; set; }
        public StudentClass Class { get; set; } = StudentClass.TE19D;
    }
}