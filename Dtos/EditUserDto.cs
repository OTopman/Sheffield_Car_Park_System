namespace Sheffield_Car_Park_System
{
    public class EditUserDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? EmailAddress { get; set; }

        public string? Password { get; set; }
    }
}