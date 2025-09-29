using AgendaApi.Models.Enum;

namespace AgendaApi.Models.DTOs.Responses
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public State State; 
        //lo datos que me interesan ver del user
    }
}
