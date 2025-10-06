using AgendaApi.Entities;
using AgendaApi.Repositories.Interfaces;

namespace AgendaApi.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>{  //lista hardcodeada de contactos
        

        new User { Id = 1, FirstName = "Maria", LastName = "Ayala", Email = "JuanPerez@gmail.com" },
        new User { Id = 2, FirstName = "José", LastName = "Gómez", Email = "RodrigoFernandez@gmail.com" },
        new User { Id = 3, FirstName = "Mario", LastName = "Pérez", Email = "AlejandraGozalez@gmail.com" },

    };
        public bool CheckifUserExists(int usarId)
        {
            throw new NotImplementedException();
        }

        public User Create(User newUser)
        {
            var nextId = _users.Count == 0 ? 1 : _users.Max(x => x.Id) + 1;
            newUser.Id = nextId;

            _users.Add(newUser);

            return newUser;
        }

        public List<User> GetAll()
        {
            return _users.ToList();
        }

        public User? GetById(int userId)
        {
            User? user = _users.FirstOrDefault(u => u.Id == userId);
                if (user is not null)
                {
                    return user;
            } return null;
        }

        public void RemoveUser(int userId)
        {
            var UserToDelete = _users.FirstOrDefault(u => u.Id == userId);
            if (UserToDelete != null)
            {
                _users.Remove(UserToDelete);
            }
        }

        public void Update(User updatedUser, int userId)
        {
            User? user = _users.FirstOrDefault(u => u.Id == userId);
            if (user is not null)
            {
                user.FirstName = updatedUser.FirstName;
                user.LastName = updatedUser.LastName;
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password;
                user.State = updatedUser.State;
            }
        }
    }
}
