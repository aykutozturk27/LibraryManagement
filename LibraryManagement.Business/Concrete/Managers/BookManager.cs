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
            //return _bookDal.GetList(includingProperties: x => x.Personal);
            return _bookDal.GetList();
        }
     
        public List<Book> GetBorrowedBookList()
        {
            //var borrowedList = _bookDal.GetList(x => x.IsBorrowed == true, x => x.Personal);
            var borrowedList = _bookDal.GetList(x => x.IsBorrowed == true);
            return borrowedList;
        }

        public List<Book> GetBookOutsideLibraryGroupedISBN()
        {
            var bookList = _bookDal.GetBookOutsideLibraryGroupedISBN();

            bookList = bookList.GroupBy(x => x.ISBN).Select(x => new Book
            {
                BookName = x.Select(x => x.BookName).FirstOrDefault(),
                Author = x.Select(x => x.Author).FirstOrDefault(),
                ISBN = x.Key,
                IsBorrowed = x.Select(x => x.IsBorrowed).FirstOrDefault(),
                ReceivingDate = x.Select(x => x.ReceivingDate).FirstOrDefault(),
                ReturnDate = x.Select(x => x.ReturnDate).FirstOrDefault(),
                PersonalId = x.Select(x => x.PersonalId).FirstOrDefault(),
                IsActive = x.Select(x => x.IsActive).FirstOrDefault(),
                //Personal = x.Select(x => x.Personal).FirstOrDefault(),
            }).ToList();

            return bookList;
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
