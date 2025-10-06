using AgendaApi.Entities;

namespace AgendaApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool CheckifUserExists(int usarId);
        User Create(User newUser);
        List<User> GetAll();
        User? GetById(int userId); 
        void RemoveUser(int userId);
        void Update (User updatedUser, int userId);

    }
}
