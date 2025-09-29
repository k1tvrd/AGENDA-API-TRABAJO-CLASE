namespace AgendaApi.Entities
{
    public class Contact
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? Address { get; set; }
        string? Number { get; set; }
        string? Email { get; set; }
        string? Image { get; set; }
        string? Company { get; set; }
        string Description { get; set; } = string.Empty; //inicializandola con un valor por defecto:empty
        int UserId { get; set; }

    }
}
