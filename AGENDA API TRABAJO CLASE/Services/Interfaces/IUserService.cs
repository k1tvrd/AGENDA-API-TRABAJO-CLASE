namespace AgendaApi.Services.Interfaces
{
    public interface IUserService
    {
        bool CheckifUserExists(int usarId);
        UserDto Create(CreateAndUpdateUserDto dto);

        IEnumerable <UserDto> GetAll();
        GetUserByIdDto? GetById (int userId);
        void RemoveUser(int userId);
        void Update(CreateAndUpdateUserDto dto, int userId);
    }
}
