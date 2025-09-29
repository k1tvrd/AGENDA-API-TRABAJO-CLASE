using AgendaApi.Entities;
using AgendaApi.Repositories.Interfaces;

namespace AgendaApi.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private static readonly List<Contact> _contacts = new List<Contact>{  //lista hardcodeada de contactos
        

        new Contact { Id = 1, FirstName = "Juan", LastName = "Perez", Address = "Acevedo 123", Number = "123456789", Email = "JuanPerez@gmail.com" },
        new Contact { Id = 1, FirstName = "Rodrigo", LastName = "Fernandez", Address = "JPaso 456", Number = "987654321", Email = "RodrigoFernandez@gmail.com" },
        new Contact { Id = 1, FirstName = "Alejandra", LastName = "Gonzalez", Address = "Colombres 789", Number = "123451234", Email = "AlejandraGozalez@gmail.com" },

    };
        public Contact Create(Contact newContact) //void se reemplaza por contact para devolver el contacto creado
        {
            // 1. Asignar un Id único
            // Usamos el conteo actual de la lista + 1 para simular un ID auto-incrementable.
            // Esto asume que tienes una lista estática llamada '_contacts'
            newContact.Id = _contacts.Count + 1;

            // 2. Agregar el nuevo contacto a la lista
            _contacts.Add(newContact);

            // 3. Devolver el contacto creado (ahora con el ID asignado)
            return newContact;
        }
        public void Delete(int id)
        {
            var UserToDelete = _contacts.FirstOrDefault(c => c.Id == id); //busca el contacto con el id especificado
            if (UserToDelete != null)
            {
                _contacts.Remove(UserToDelete); //si lo encuentra, lo elimina de la lista
            }
        }
        public IEnumerable<Contact> GetAllByUser(int id)
        {
            // Usamos 'ToList()' para devolver una copia de la lista de contactos.
            // Esto simula la recuperación de múltiples registros de la "base de datos"
            // (En un caso real, aquí filtrarías por 'c.UserId == id').
            return _contacts.ToList();
        }

        public Contact? GetByContactId(int contactId)
        {
            throw new NotImplementedException();
        }

        public Contact? GetOneByUser(int userId, int contactId)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact updatedContact, int contactId)
        {
            throw new NotImplementedException();
        }

        void IContactRepository.Create(Contact newContact) //se pone solo para q no de error ?
        {
            throw new NotImplementedException();
        }
    }
}
