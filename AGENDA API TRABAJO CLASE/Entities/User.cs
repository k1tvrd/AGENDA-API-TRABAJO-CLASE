using AgendaApi.Models.Enum;

namespace AgendaApi.Entities
{
    public class User
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        public State State { get; set; } = State.Active;

    }
   
}
