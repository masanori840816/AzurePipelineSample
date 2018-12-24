using System;
using System.Collections.Generic;
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
    }
}
