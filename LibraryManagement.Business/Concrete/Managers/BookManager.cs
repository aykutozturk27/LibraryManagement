using LibraryManagement.Business.Abstract;
using LibraryManagement.DataAccess.Abstract;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.Concrete.Managers
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetBookWithPersonalList()
        {
            return _bookDal.GetList(includeProperties: x => x.Personal);
        }
     
        public List<Book> GetBorrowedBookList()
        {
            var borrowedList = _bookDal.GetList(x => x.IsBorrowed == true, x => x.Personal);
            return borrowedList;
        }

        public List<Book> GetBookOutsideLibraryGroupedISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public Book SetBookBorrowedByIdentity(string identityNumber)
        {
            var borrowedBook = _bookDal.Get(x => x.Personal.IdentityNumber == identityNumber,
                x => x.Personal);

            borrowedBook.IsBorrowed = true;

            var updatedBorrowedBook = _bookDal.Update(borrowedBook);

            return updatedBorrowedBook;
        }

        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }
    }
}
