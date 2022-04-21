using FinalProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FinalProjectTests
{
    public class HomeTests
    {
        [Fact]
        public void IndexMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void WickNMMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.WickNM();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void AdkinsDKMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.AdkinsDK();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void MacleoJBMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.MacleoJB();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void SchrieBAMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.SchrieBA();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PrivacyMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.Privacy();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void AboutUsMethod_ReturnsAViewResult()
        {
            var controller = new HomeController();
            var result = controller.AboutUs();
            Assert.IsType<ViewResult>(result);
        }
    }
}
