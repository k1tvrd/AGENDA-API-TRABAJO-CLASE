using AgendaApi.Entities;
using AgendaApi.Models.DTOs.Responses;

namespace AgendaApi.Repositories.Interfaces
{
    public interface IContactRepository
    {
        Contact Create(Contact newContact);
        void Delete (int id);
        IEnumerable<Contact> GetAllByUser(int id);
        Contact? GetByContactId(int contactId);
        Contact? GetOneByUser(int userId, int contactId);
        void Update(Contact updatedContact, int contactId);
    }
}
