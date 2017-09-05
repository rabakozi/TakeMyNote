using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TakeMyNote.DataAccess;

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
