using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWcfApp.NoteService;
using TestWcfApp.UserService;

namespace TestWcfApp
{
    [TestFixture]
    public class TestUserService
    {
        [Test]
        public void CreateUser()
        {
            var service = new UserService.UserServiceClient("BasicHttpBinding_IUserService");
            service.Create(new User
            {
                FirstName = "Joe",
                LastName = "Doo"
            });

            var users = service.GetAll();
        }
    }
}
