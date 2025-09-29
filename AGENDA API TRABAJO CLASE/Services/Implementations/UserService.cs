using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Services.Interfaces;

namespace AgendaApi.Services.Implementations
{
    public class UserService : IUserService
    {
        public bool CheckifUserExists(int usarId)
        {
            throw new NotImplementedException();
        }

        public UserDto Create(CreateAndUpdateUserDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public GetUserByIdDto? GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(CreateAndUpdateUserDto dto, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
