namespace AgendaApi.Models.DTOs.Requests
{
    public class CreateAndUpdateContactDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? Number { get; set; }
        public string? Image { get; set; }
        public string? Company { get; set; }
        public string Description { get; set; } = string.Empty; //inicializandola con un valor por defecto:empty
        public int UserId { get; set; }
    }
}
