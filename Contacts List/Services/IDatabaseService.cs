namespace Contacts_List.Services
{
    // Defines the contract for database operations related to Contact entities
    internal interface IDatabaseService
    {
        public Task<List<Contact>> GetContacts(); // Retrieves all contacts

        public Task<Contact> GetContactById(short id); // Retrieves a contact by its ID

        public Task Create(Contact contact); // Inserts a new contact

        public Task Update(Contact contact); // Updates an existing contact

        public Task Delete(Contact contact); // Deletes a new contact
    }
}
