using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.Abstract
{
    public interface IPersonalService
    {
        List<Personal> GetAll();
        Personal Add(Personal personal);
    }
}
