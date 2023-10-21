using LibraryManagement.Core.Entities;

namespace LibraryManagement.Entities.Concrete
{
    public class Book : BaseEntity
    {
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsBorrowed { get; set; } = false;

        public Personal? Personal { get; set; }
        public int PersonalId { get; set; }
    }
}
