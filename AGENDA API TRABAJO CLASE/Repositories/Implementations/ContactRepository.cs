using AgendaApi.Entities;

namespace AgendaApi.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly List<Contact> _contacts = new(); 

        public void Create(Contact newContact)
        {
            newContact.Id = _contacts.Count > 0 ? _contacts.Max(c => c.Id) + 1 : 1;  //ID incremental
            _contacts.Add(newContact);
        }
        void Delete(int id);
        IEnumerable<Contact> GetAllByUser(int id);
        Contact? GetByContactId(int contactId);
        Contact? GetOneByUser(int userId, int contactId);
        void Update(Contact updatedContact, int contactId);
    }
}
}
