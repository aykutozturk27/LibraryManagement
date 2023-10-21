using Autofac;
using LibraryManagement.Business.Abstract;
using LibraryManagement.Business.Concrete.Managers;
using LibraryManagement.DataAccess.Abstract;
using LibraryManagement.DataAccess.Concrete.EntityFramework;

namespace LibraryManagement.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonalManager>().As<IPersonalService>().SingleInstance();
            builder.RegisterType<EfPersonalDal>().As<IPersonalDal>().SingleInstance();

            builder.RegisterType<BookManager>().As<IBookService>().SingleInstance();
            builder.RegisterType<EfBookDal>().As<IBookDal>().SingleInstance();
        }
    }
}
