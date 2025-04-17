using SQLite;

namespace Contacts_List.Services
{
    // Concrete implementation of IDatabaseService using SQLite
    public class DatabaseService : IDatabaseService
    {
        private const string DB_NAME = "application.db3";
        private readonly SQLiteAsyncConnection _connection;

        public DatabaseService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Contact>(); // Ensures Contact table exists
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _connection.Table<Contact>().ToListAsync(); // Retrieves all contacts
        }

        public async Task<Contact> GetContactById(short id)
        {
            return await _connection.Table<Contact>().Where(c => c.Id == id.ToString()).FirstOrDefaultAsync(); // Finds contact by ID
        }

        public async Task Create(Contact contact)
        {
            await _connection.InsertAsync(contact); // Inserts new contact
        }

        public async Task Update(Contact contact)
        {
            await _connection.UpdateAsync(contact); // Updates existing contact
        }

        public async Task Delete(Contact contact)
        {
            await _connection.DeleteAsync(contact); // Deletes contact
        }
    }
}
