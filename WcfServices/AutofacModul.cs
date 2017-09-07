﻿using Autofac;
using TakeMyNote.WcfService;

namespace TakeMyNote.WcfServices
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register your service implementations.
            builder.RegisterType<NoteService>().As<INoteService>();

            builder.RegisterModule(new Repositories.AutofacModule());
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