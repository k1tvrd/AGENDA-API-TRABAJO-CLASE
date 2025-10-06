using AgendaApi.Entities;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Repositories.Interfaces;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace AgendaApi.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private static readonly List<Contact> _contacts = new List<Contact>{  //lista hardcodeada de contactos
        

        new Contact { Id = 1, FirstName = "Juan", LastName = "Perez", Address = "Acevedo 123", Number = "123456789", Email = "JuanPerez@gmail.com", UserId = 1},
        new Contact { Id = 2, FirstName = "Rodrigo", LastName = "Fernandez", Address = "JPaso 456", Number = "987654321", Email = "RodrigoFernandez@gmail.com", UserId = 4},
        new Contact { Id = 3, FirstName = "Alejandra", LastName = "Gonzalez", Address = "Colombres 789", Number = "123451234", Email = "AlejandraGozalez@gmail.com", UserId = 4},

    };
        public Contact Create(Contact newContact) 
        {
            var nextId = _contacts.Count == 0 ? 1 : _contacts.Max(x => x.Id) + 1;
            newContact.Id = nextId;

            _contacts.Add(newContact);

            return newContact;
        }
        //operador ternario (condición ? valorSiTrue : valorSiFalse)
        //Si la lista de contactos está vacía(_contacts.Count == 0), el próximo Id va a ser 1.
        //Si no está vacía, toma el máximo Id existente(_contacts.Max(x => x.Id)) y le suma 1.
        //Asegura que cada nuevo contacto tenga un Id único y creciente.
        public void Delete(int id)
        {
            var UserToDelete = _contacts.FirstOrDefault(c => c.Id == id); //busca el contacto con el id especificado
            if (UserToDelete != null)
            {
                _contacts.Remove(UserToDelete); //si lo encuentra, lo elimina de la lista
            }
        }
        //Recorre la lista _contacts y busca el primer contacto cuyo Id sea igual al id que recibimos como parámetro.
        //Si lo encuentra → guarda ese contacto en UserToDelete.
        //Si no lo encuentra → devuelve null (por eso se usa FirstOrDefault).
        //Solo entra al if si realmente encontró un contacto con ese Id.
        //En contacts.Remove borra ese objeto de la lista _contacts.

        //C REPRESENTA A CADA CONTACTO DE LA LISTA CONTACT
        public IEnumerable<Contact> GetAllByUser(int id)
        {
            return _contacts.Where(c => c.UserId == id);
        }
        //Recorre la lista de contactos y devuelve todos los que cumplan la condición: que su Id sea igual al id recibido.
        //Como Where puede devolver varios elementos (no solo uno), el resultado es una colección de contactos, no un solo contacto.
        //Esa colección la devuelve como IEnumerable<Contact>

        public Contact? GetByContactId(int contactId)
        {
            Contact? contact = _contacts.FirstOrDefault(c => c.Id == contactId);
            if (contact is not null)
            {
                return contact;
            }
            return null;
        }
        //FirstOrDefault recorre la lista _contacts.
        //Devuelve el primer contacto que cumpla la condición(c.Id == contactId).
        //Si no encuentra ninguno, devuelve null.
        //Por eso el tipo es Contact? (con el ?), indicando que puede ser Contact o null.

        public Contact? GetOneByUser(int userId, int contactId)
        {
            return _contacts.FirstOrDefault(c => c.UserId == userId && c.Id == contactId);
        }
       //c representa cada contacto de la lista _contacts mientras se recorre
       //c.UserId == userId → el contacto debe pertenecer al usuario indicado.
       //c.Id == contactId → además debe tener ese Id específico.
      //El && significa “y” → ambas cosas deben cumplirse al mismo tiempo.
      //FirstOrDefault(...) Busca en la lista el primer contacto que cumpla esa condición.
      //Si encuentra uno → lo devuelve. Si no encuentra ninguno → devuelve null.

        public void Update(Contact updatedContact, int contactId)
        {
            Contact? contact = _contacts.SingleOrDefault(c => c.Id == contactId);
            if(contact is not null)
            {
                contact.FirstName = updatedContact.FirstName;   
                contact.LastName = updatedContact.LastName; 
                contact.Email = updatedContact.Email;
                contact.Address = updatedContact.Address;
                contact.Number = updatedContact.Number;
                contact.Description = updatedContact.Description;
                contact.Image = updatedContact.Image;
                contact.UserId = updatedContact.UserId;
                contact.Company = updatedContact.Company;
            }
        }

    }
}
