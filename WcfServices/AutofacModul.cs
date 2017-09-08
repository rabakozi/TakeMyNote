using Autofac;

namespace TakeMyNote.WcfServices
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register your service implementations.
            builder.RegisterType<NoteService>().As<INoteService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterModule(new Repositories.AutofacModule());
        }
    }
}
