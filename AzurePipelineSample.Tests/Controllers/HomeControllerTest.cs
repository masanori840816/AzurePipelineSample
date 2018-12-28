using AzurePipelineSample.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace AzurePipelineSample.Tests.Controllers
{
    public class HomeControllerTest
    {
        private readonly HomeController _controller;

        public HomeControllerTest()
        {
            _controller = new HomeController();
        }
        [Fact]
        public void Index_OpenAndGetType()
        {
            Assert.IsType<ViewResult>(_controller.Index());
        }

        [Fact]
        public void GetAllUsers_GetMoreThanOneUsers()
        {
            var users = _controller.GetAllUsers();
            Assert.NotNull(users);
            Assert.True(users.Count > 0);
        }
    }
}
