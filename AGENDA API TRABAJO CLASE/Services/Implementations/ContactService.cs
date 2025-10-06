using AgendaApi.Entities;
using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using AgendaApi.Repositories.Implementations;
using AgendaApi.Repositories.Interfaces;
using AgendaApi.Services.Interfaces;

namespace AgendaApi.Services.Implementations
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository; //IMPO implementando contactRepository para usar sus metodos

        public ContactService (IContactRepository contactRepository) 
        {
            _contactRepository = contactRepository;
        }
        public ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId)
        {
            Contact contact = new Contact()
            {
                Address = dto.Address,
                Company = dto.Company,
                Description = dto.Description,
                Email = dto.Email,
                FirstName = dto.FirstName,
                Image = dto.Image,
                LastName = dto.LastName,
                Number = dto.Number,
                UserId = loggedUserId
            };

            var newContact = _contactRepository.Create(contact);

            var contactDto = new ContactDto
            {
                FirstName = newContact.FirstName,
                LastName = newContact.LastName,
                Email = newContact.Email,
            };

            return contactDto;
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        public List<ContactDto> GetAllByUser(int id)
        {
            return _contactRepository.GetAllByUser(id).Select(c => new ContactDto
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email,
            }).ToList();
        }

        public ContactDto? GetOneByUserId(int userId, int contactId)
        {
            Contact? contact = _contactRepository.GetOneByUser(userId, contactId);
            ContactDto response = new ContactDto
            {
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,
              
            };
            return response;
        }
        public void Update(CreateAndUpdateContactDto dto, int contactId)
        {
            Contact? contact = _contactRepository.GetByContactId(contactId);
            if (contact is not null) {                 
                contact.Address = dto.Address;
                contact.Company = dto.Company;
                contact.Description = dto.Description;
                contact.Email = dto.Email;
                contact.FirstName = dto.FirstName;
                contact.Image = dto.Image;
                contact.LastName = dto.LastName;
                contact.Number = dto.Number;
                _contactRepository.Update(contact, contactId);
            }
        }
    }
}
