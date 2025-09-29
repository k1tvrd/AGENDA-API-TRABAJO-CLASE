using AgendaApi.Entities;
using AgendaApi.Repositories.Interfaces;

namespace AgendaApi.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public bool CheckifUserExists(int usarId)
        {
            throw new NotImplementedException();
        }

        public int Create(User newUser)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User? GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(User updatedUser, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
