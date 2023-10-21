using LibraryManagement.Business.Abstract;
using LibraryManagement.DataAccess.Abstract;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.Concrete.Managers
{
    public class PersonalManager : IPersonalService
    {
        private readonly IPersonalDal _personalDal;

        public PersonalManager(IPersonalDal personalDal)
        {
            _personalDal = personalDal;
        }

        public List<Personal> GetAll()
        {
            return _personalDal.GetList();
        }

        public Personal Add(Personal personal)
        {
            return _personalDal.Add(personal);
        }
    }
}
