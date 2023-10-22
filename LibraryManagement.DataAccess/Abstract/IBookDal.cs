using LibraryManagement.Core.DataAccess;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<Book> GetBookOutsideLibraryGroupedISBN();
    }
}
