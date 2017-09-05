using Autofac;

namespace TakeMyNote.WebApi
{
    public class AutofacModul : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //RegisterDbContextFactory<DesignTimeDbContextFactory<AutoClassificationDataContext>, IDesignTimeDbContextFactory<AutoClassificationDataContext>>(builder);

        }

        //
        // Helper methods
        //
        private void RegisterDbContextFactory<TDbContextFactory, TIDbContextFactory>(ContainerBuilder builder)
        {
            builder
                .RegisterType<TDbContextFactory>()
                .As<TIDbContextFactory>()
                .InstancePerDependency();
        }
    }
}
