using CRUD_Operation;
using CRUD_Operation.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CRUD_Operation.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Read()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Read() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Update()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Update(1001) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}