namespace AgendaApi.Models.DTOs.Requests
{
    public class CreateAndUpdateUserDto
    {
        [Required]
        [EmailAddress] //para validar que el formato del correo es correcto
        string Email { get; set; }

       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }
       public string PhoneNumber { get; set; }
       public string Password { get; set; }
    }
}
