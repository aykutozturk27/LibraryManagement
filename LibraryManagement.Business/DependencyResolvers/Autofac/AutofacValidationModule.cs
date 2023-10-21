using Autofac;
using FluentValidation;
using LibraryManagement.Business.ValidationRules.FluentValidation;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.DependencyResolvers.Autofac
{
    public class AutofacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonalValidator>().As<IValidator<Personal>>().SingleInstance();
            builder.RegisterType<BookValidator>().As<IValidator<Book>>().SingleInstance();
        }
    }
}
