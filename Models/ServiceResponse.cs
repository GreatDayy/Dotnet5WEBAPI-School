namespace dotnet5.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool isSuccessFul {get; set; } = true;


        public string Message {get; set;} = null;
    }
}