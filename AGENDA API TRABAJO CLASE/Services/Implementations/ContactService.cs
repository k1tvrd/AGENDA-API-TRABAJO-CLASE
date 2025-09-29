using AgendaApi.Entities;
using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Services.Interfaces;

namespace AgendaApi.Services.Implementations
{
    public class ContactService : IContactService
    {
        public ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactDto> GetAllByUser(int id)
        {
            throw new NotImplementedException();
        }

        public ContactDto? GetOneByUserId(int userId, int contactId)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact updatedContact, int contactId)
        {
            throw new NotImplementedException();
        }
    }
}
