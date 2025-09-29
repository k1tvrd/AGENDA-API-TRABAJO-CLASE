using AgendaApi.Entities;

namespace AgendaApi.Services.Interfaces
{
    public interface IContactService
    {
        ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId);
        void Delete(int id);
        List<ContactDto> GetAllByUser(int id);
        ContactDto? GetOneByUserId(int userId, int contactId);
        void Update(Contact updatedContact, int contactId);
    }
}
