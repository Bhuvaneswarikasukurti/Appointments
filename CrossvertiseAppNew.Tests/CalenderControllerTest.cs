using System;
using System.Web.Mvc;
using CrossvertiseAppNew.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrossvertiseAppNew.Tests
{
    [TestClass]
    public class CalenderControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CalenderController controller = new CalenderController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GetMonthDetails()
        {
            // Arrange
            CalenderController controller = new CalenderController();

            // Act
            var result = controller.GetMonthDetails(1) as PartialViewResult;

            // Assert
            Assert.AreEqual("_monthDetails", result.ViewName);
        }

        [TestMethod]
        public void GetMonthDetailsNotInID()
        {
            // Arrange
            CalenderController controller = new CalenderController();

            // Act
            var result = controller.GetMonthDetails(13) as ViewResult;

            // Assert
            Assert.AreEqual("ErrorPage", result.ViewName);
        }

        [TestMethod]
        public void GetMeetingDetails()
        {
            // Arrange
            CalenderController controller = new CalenderController();

            // Act
            var result = controller.GetMeetingDetails(1) as PartialViewResult;

            // Assert
            Assert.AreEqual("_meetingInfo", result.ViewName);
        }

        [TestMethod]
        public void GetMeetingDetailsNotInId()
        {
            // Arrange
            CalenderController controller = new CalenderController();

            // Act
            var result = controller.GetMeetingDetails(0) as ViewResult;

            // Assert
            Assert.AreEqual("ErrorPage", result.ViewName);
        }
    }
}
