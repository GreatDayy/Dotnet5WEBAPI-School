namespace dotnet5.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name {get; set;} = "Arvid";

        public int Age { get; set; }
        public StudentClass Class {get; set;} = StudentClass.TE19D;
        
    }
}