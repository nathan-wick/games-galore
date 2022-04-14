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
        public void TestIndex()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestWickNM()
        {
            var controller = new HomeController();
            var result = controller.WickNM();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestAdkinsDK()
        {
            var controller = new HomeController();
            var result = controller.AdkinsDK();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestMacleoJB()
        {
            var controller = new HomeController();
            var result = controller.MacleoJB();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestSchrieBA()
        {
            var controller = new HomeController();
            var result = controller.SchrieBA();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestPrivacy()
        {
            var controller = new HomeController();
            var result = controller.Privacy();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestAboutUs()
        {
            var controller = new HomeController();
            var result = controller.AboutUs();
            Assert.IsType<ViewResult>(result);
        }
    }
}
