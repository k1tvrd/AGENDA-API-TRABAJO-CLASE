using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Repositories.Implementations;
using AgendaApi.Repositories.Interfaces;
using AgendaApi.Services.Interfaces;
using System.Security.Cryptography.Xml;
using AgendaApi.Entities;
using System.Reflection.Metadata.Ecma335;

namespace AgendaApi.Services.Implementations
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository; //IMPO implementando userepository para usar sus metodos
        public UserService(IUserRepository userRepository)
        //Esto declara un atributo o campo privado dentro de la clase UserService.
        //Propósito: guardar una referencia al repositorio de usuarios para poder usar sus métodos detro de esta clase.
        //Esta línea no crea la instancia, solo define que existirá un espacio para guardarla.

        {
            _userRepository = userRepository;
        }
        //Esto es un constructor de la clase UserService.
        //Propósito: recibir una instancia concreta de IUserRepository desde afuera(inyección de dependencias) y guardarla en el campo privado _userRepository.
        //La línea _userRepository = userRepository; hace la asignación real, ahora _userRepository apunta a un objeto que implementa la interfaz.
        public bool CheckifUserExists(int userId)
        {
            return _userRepository.CheckifUserExists(userId); //llama a método de user repository
        }

        public UserDto Create(CreateAndUpdateUserDto dto) //principio-> devuelve el metodo. Parametro-> lo que recibe
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password
            };

            var newUser = _userRepository.Create(user);

            var userDto = new UserDto
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                State = newUser.State
            };

            return userDto;
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userRepository.GetAll().Select(user => new UserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                State = user.State
            }).ToList();
        }

        public GetUserByIdDto? GetById(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user != null)
            {
                return new GetUserByIdDto
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    State = user.State
                };
            }
            return null;
        }

        public void RemoveUser(int userId)
        {
            _userRepository.RemoveUser(userId);
        }

        public void Update(CreateAndUpdateUserDto dto, int userId)
        {
            User? user = _userRepository.GetById(userId);
            if (user != null)
            {
                user.FirstName = dto.FirstName;
                user.LastName = dto.LastName;
                user.Email = dto.Email;
                user.Password = dto.Password;
                _userRepository.Update(user, userId);
            }
        }
    }
}
