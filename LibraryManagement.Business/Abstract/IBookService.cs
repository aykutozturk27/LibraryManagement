using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetBookWithPersonalList(); // kitapların personal ile birlikte joinlendiği liste
        List<Book> GetBorrowedBookList(); // ödünç alınan kitapların listesi
        List<Book> GetBookOutsideLibraryGroupedISBN(string isbn); // kitabın kütüphane dışında geçirdiği süre listesi
        Book SetBookBorrowedByIdentity(string identityNumber); // kitabı ödünç alınan yap
        Book Add(Book book); // kitap ekleme
    }
}
