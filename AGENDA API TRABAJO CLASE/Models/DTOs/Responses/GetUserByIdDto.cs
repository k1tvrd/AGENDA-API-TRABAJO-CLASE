using AgendaApi.Models.Enum;

namespace AgendaApi.Models.DTOs.Responses
{
    public class GetUserByIdDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public State State;
    }
}
