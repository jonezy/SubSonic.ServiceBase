using System.Collections.Generic;
using System.Web.Mvc;

using ExampleSite.Controllers;
using ExampleSite.Infrastructure.Data;
using ExampleSite.Infrastructure.Services;
using ExampleSite.Models;

using NUnit.Framework;
using Rhino.Mocks;

namespace ExampleSite.Tests {
    [TestFixture]
    public class HomeControllerTests {
        const string expectedIndexViewName = "Index";
        UserService userService;
        HomeController homeController;

        [SetUp]
        public void Setup() {
            userService = MockRepository.GenerateStub<UserService>();
            homeController = new HomeController(userService);
            
            // setup a result for the getdata call
            userService.Stub(u => u.GetData<User, ExampleSiteDB>(i => i.IsActive == true))
                .IgnoreArguments()
                .Return(new List<User>());
        }

        [Test]
        public void Index_action_should_return_index_view() {
            // Act
            var result = homeController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");
            Assert.AreEqual(expectedIndexViewName, result.ViewName, "View name should have been {0}", expectedIndexViewName);
        }

        [Test]
        public void Index_action_should_return_indexviewmodel() {
            // Act
            var result = homeController.Index() as ViewResult;

            var model = result.ViewData.Model as IndexViewModel;

            Assert.IsNotNull(model, "Model shouldn't be null");
            Assert.IsInstanceOf<IndexViewModel>(model, "Model should have been type of IndexViewModel");
        }
    }
}
