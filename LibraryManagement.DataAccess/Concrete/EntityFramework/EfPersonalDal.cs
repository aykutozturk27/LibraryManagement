using LibraryManagement.Core.DataAccess.EntityFramework;
using LibraryManagement.DataAccess.Abstract;
using LibraryManagement.DataAccess.Concrete.EntityFramework.Contexts;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.DataAccess.Concrete.EntityFramework
{
    public class EfPersonalDal : EfEntityRepositoryBase<Personal, LibraryManagementContext>, IPersonalDal
    {
    }
}
