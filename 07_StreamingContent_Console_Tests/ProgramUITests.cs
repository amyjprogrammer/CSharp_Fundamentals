using _07_StreamingContent_Console1;
using _07_StreamingContent_Console1.Consoles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Console_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetAllContent_OutputShouldContainCorrectTitles()
        {
            //Arrange
            //2
            //6
            List<string> commandList = new List<string> { "2", "6" };

            MockConsole console = new MockConsole(commandList);

            ProgramUI ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains("Space Opera"));
        }
        //Get by Title

        //Create Content
        //1
        //Title
        //Description

        //Update Content

        [TestMethod]
        public void RemoveContent_ShouldNoLongerSeeRemovedContent()
        {
            //Arrange
            //5 - key presses within the console to remove a title
            //2 removing title two
            //2 verifying the remove worked
            //6 exit

            List<string> commandList = new List<string> { "5", "2", "2", "6" };

            MockConsole console = new MockConsole(commandList);

            ProgramUI ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsFalse(console.Output.Contains("mind bending"));
        }
    }
}
