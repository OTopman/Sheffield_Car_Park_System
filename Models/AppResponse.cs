namespace Sheffield_Car_Park_System.Models
{
    public class AppResponse<T>
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}