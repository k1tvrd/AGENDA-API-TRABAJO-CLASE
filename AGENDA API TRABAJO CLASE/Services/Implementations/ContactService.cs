using AgendaApi.Entities;
using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Services.Interfaces;

namespace AgendaApi.Services.Implementations
{
    public class ContactService : IContactService
    {
        ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId);
        void Delete(int id);
        List<ContactDto> GetAllByUser(int id);
        ContactDto? GetOneByUserId(int userId, int contactId);
        void Update(Contact updatedContact, int contactId);
    }
}
