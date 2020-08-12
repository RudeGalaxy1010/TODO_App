using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TODOApp.BL.Models.Tests
{
    [TestClass()]
    public class FileDataSaverTests
    {
        [TestMethod()]
        public void FileDataSaverTest()
        {
            //Arrange
            var saver = new FileDataSaver();
            var data = new List<Task>()
            {
                new Task("testTask_1"),
                new Task("testTask_2"),
                new Task("testTask_3")
            };

            //Act
            saver.Save(data);
            var loadedData = saver.Load();

            //Assert
            Assert.AreEqual(data.Count, loadedData.Count);
            for (int i = 0;  i < data.Count; i++)
            {
                Assert.AreEqual(data[i].Content, loadedData[i].Content);
                Assert.AreEqual(data[i].CreateDate, loadedData[i].CreateDate);
                Assert.AreEqual(data[i].IsDone, loadedData[i].IsDone);
                Assert.AreEqual(data[i].TaskId, loadedData[i].TaskId);
            }
        }
    }
}