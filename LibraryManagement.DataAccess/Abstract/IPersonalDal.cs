using LibraryManagement.Core.DataAccess;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.DataAccess.Abstract
{
    public interface IPersonalDal : IEntityRepository<Personal>
    {
    }
}
