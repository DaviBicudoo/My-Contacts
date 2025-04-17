using SQLite;

namespace Contacts_List.MVVM.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(100), Unique]
        public string Name { get; set; }

        [NotNull, MaxLength(30), Unique]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(150)]
        public string? Address { get; set; }

        public byte[]? ProfileImage { get; set; }

        [MaxLength(500)] 
        public string? Notes { get; set; }
    }
}