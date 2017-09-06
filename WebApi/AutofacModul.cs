using Autofac;
using TakeMyNote.WebApi.Services;

namespace TakeMyNote.WebApi
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<NotesService>()
                .As<INotesService>()
                .SingleInstance();
        }

        ////
        //// Helper methods
        ////
        //private void RegisterDbContextFactory<TDbContextFactory, TIDbContextFactory>(ContainerBuilder builder)
        //{
        //    builder
        //        .RegisterType<TDbContextFactory>()
        //        .As<TIDbContextFactory>()
        //        .InstancePerDependency();
        //}
    }
}
