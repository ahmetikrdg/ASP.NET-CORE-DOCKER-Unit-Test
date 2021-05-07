using Microsoft.AspNetCore.Mvc;
using SonHelloApp.Controllers;
using SonHelloApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HelloTest
{
    public class HomeTest
    {
        private HomeController _homeController;
        public HomeTest()
        {
            _homeController = new HomeController();
        }

        [Fact]
        public void Index_ActionExecutes_ReturnView()
        {
            var result = _homeController.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Privacy_ActionExecutes_ReturnView()
        {
            var result = _homeController.Privacy();     
            Assert.IsType<ViewResult>(result);
        }


    }
}
