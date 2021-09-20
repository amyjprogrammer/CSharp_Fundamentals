using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange getting what we need to run our tests.
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool success = repository.AddContentToDirectory(content);
            

            //Assert
            Assert.IsTrue(success);
        }

        //testing Read method (GET)
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollectList()
        {
            //Arrange
            StreamingContent matrix = new StreamingContent("Matrix", "Mind bending scifi", 1.75, 8.7, "SciFi", MaturityRating.PG13);
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(matrix);

            //Act
            List<StreamingContent> movieList = repo.GetContents();

            bool success = movieList.Contains(matrix);


            //Assert
            Assert.IsTrue(success);
        }
    }
}
