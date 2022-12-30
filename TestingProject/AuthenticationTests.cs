using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Webshop_Backend.Controllers;
using Webshop_Backend.Context;
using Xunit;
using Webshop_Backend.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webshop_Backend.DTO_s;

namespace TestingProject
{
    public class AuthenticationTests
    {
/*        private UserController Initialize([CallerMemberName] string callerName = "")
        {
            var options = new DbContextOptionsBuilder<ApplicationDBContext>().UseInMemoryDatabase(databaseName: "InMemoryProductDb_" + callerName).Options;
            var context = new ApplicationDBContext(options);
            SeedProductInMemoryDatabaseWithData(context);
            return new UserController(context);
        }
        private TokenController InitializeToken([CallerMemberName] string callerName = "")
        {
            var options = new DbContextOptionsBuilder<ApplicationDBContext>().UseInMemoryDatabase(databaseName: "InMemoryProductDb_" + callerName).Options;
            var context = new ApplicationDBContext(options);
            SeedProductInMemoryDatabaseWithData(context);
            return new TokenController();
        }


        private void SeedProductInMemoryDatabaseWithData(ApplicationDBContext DBcontext)
        {
            var Users = new List<User>
            {
                new User { AccountID = 1, Username = "Henk", Email = "Henk@test.nl", Password = "SpaRood23" },
                new User { AccountID = 2, Username = "Pieter", Email = "Pieter@test.nl", Password = "DikkeBeer58"},
                new User { AccountID = 3, Username = "Gertje", Email = "Gertje@test.nl", Password = "Jonkerd"},
                new User { AccountID = 4, Username = null, Password = null, },
            };
            if (!DBcontext.users.Any())
            {
                DBcontext.users.AddRange(User);
            }
            DBcontext.SaveChanges();
        }

        [Fact]
        private void LoginUser_shouldloginuseraftertokengen()
        {

            var controller = Initialize();
            var controller2 = InitializeToken();
            var usermodel = new User();
            string test = controller2.nonExistentToken("Henk@test.nl");
            var result = controller.Login(test, usermodel);
            Assert.IsType<string>(result);

        }

        [Fact]
        private void LoginToken_shouldloginuser()
        {
            var controller = Initialize();
            var usermodel = new User();

            var result = controller.loginNoToken("Henk@test.nl", "SpaRood");
            Assert.IsType<string>(result);
        }

        [Fact]
        private void Register_shouldregisteruser()
        {
            var controller = Initialize();
            var usermodel = new User();

            var result = controller.register(usermodel);
            Assert.IsType<string>(result);
        }


        [Fact]
        private void CreateToken_shouldcreatetoken()
        {
            var controller = InitializeToken();

            var result = controller.GenerateToken();
            Assert.IsType<ObjectResult>(result);
        }

        [Fact]
        private void ReadOut_shouldreadouttoken()
        {
            var controller = InitializeToken();
            string test = controller.nonExistentToken("Henk@test.nl");
            var result = controller.readOutToken(test).ToString();
            //convert test naar token lees claims uit en assert per item claim.

            Assert.IsType<string>(result);
        }


        [Fact]
        private void NonexistentToken_shouldgeneratenewtoken()
        {
            var controller = InitializeToken();

            var result = controller.nonExistentToken("Henk@test.nl");
            Assert.IsType<string>(result);
        }*/
    }
}