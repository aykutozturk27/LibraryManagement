using LibraryManagement.Core.DataAccess.EntityFramework;
using LibraryManagement.DataAccess.Abstract;
using LibraryManagement.DataAccess.Concrete.EntityFramework.Contexts;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryManagementContext>, IBookDal
    {
        public List<Book> GetBookOutsideLibraryGroupedISBN()
        {
            using (var context = new LibraryManagementContext())
            {
                var list = (from book in context.Books
                            let betweenDates = book.ReceivingDate > book.ReturnDate
                            orderby betweenDates descending
                            select book).ToList();

                return list;
            }
        }
    }
}
