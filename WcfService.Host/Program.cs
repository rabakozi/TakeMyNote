using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Autofac.Integration.Wcf;
using TakeMyNote.WcfServices;

namespace TakeMyNote.WcfService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            // Register your service implementations.
            builder.RegisterModule(new WcfServices.AutofacModule());
            //var container = builder.Build();

            using (var container = builder.Build())
            {
                //Uri address = new Uri("http://localhost:9001/NoteService");
                ServiceHost host = new ServiceHost(typeof(NoteService));//, address);
                //host.AddServiceEndpoint(typeof(INoteService), new BasicHttpBinding(), string.Empty);

                // Here's the important part - attaching the DI behavior to the service host
                // and passing in the container.
                host.AddDependencyInjectionBehavior<INoteService>(container);

                //host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true, HttpGetUrl = address });
                host.Open();

                ServiceHost host2 = new ServiceHost(typeof(UserService));//, address);
                host2.AddDependencyInjectionBehavior<IUserService>(container);
                host2.Open();

                Console.WriteLine("The hosts have been opened.");
                Console.ReadLine();

                host.Close();
                Environment.Exit(0);
            }
            
        }
    }
}
