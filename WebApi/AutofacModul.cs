using Autofac;

namespace TakeMyNote.WebApi
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder
            //    .RegisterType<NotesService>()
            //    .As<INotesService>()
            //    .SingleInstance();
        }
    }
}
