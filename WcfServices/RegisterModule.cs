using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMyNote.WcfServices
{
    public static class RegisterModule
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new Repositories.AutofacModule());
            builder.Build();
        }
    }
}
