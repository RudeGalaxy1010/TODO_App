using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TODOApp.BL.Models;

namespace TODOApp.BL.Controller.Tests
{
    [TestClass()]
    public class TaskControllerTests
    {
        [TestMethod()]
        public void TaskControllerTest()
        {
            //Arrange
            var controller = new TaskController();
            var testTask = new Task("Test");

            //Act
            controller.AddTask(testTask);
            var lastTask = controller.Tasks.Last();

            //Assert
            Assert.AreEqual(testTask.Content, lastTask.Content);
            Assert.AreEqual(testTask.CreateDate, lastTask.CreateDate);
            Assert.AreEqual(testTask.IsDone, lastTask.IsDone);
            Assert.AreEqual(lastTask.TaskId, controller.Tasks.Count - 1);
        }
    }
}