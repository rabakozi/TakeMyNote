using Autofac;
using Microsoft.EntityFrameworkCore.Design;

namespace TakeMyNote.DataAccess
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<DesignTimeDbContextFactory>()
                .As<IDesignTimeDbContextFactory<DatabaseContext>>()
                .InstancePerDependency();
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
