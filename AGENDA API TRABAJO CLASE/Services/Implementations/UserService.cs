using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Services.Interfaces;

namespace AgendaApi.Services.Implementations
{
    public class UserService : IUserService
    {
        bool CheckifUserExists(int usarId);
        UserDto Create(CreateAndUpdateUserDto dto);
        IEnumerable<UserDto> GetAll();
        GetUserByIdDto? GetById(int userId);
        void RemoveUser(int userId);
        void Update(CreateAndUpdateUserDto dto, int userId);
    }
}
