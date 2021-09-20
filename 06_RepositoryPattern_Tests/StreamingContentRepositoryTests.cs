using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        //These fields were added later
        private StreamingContentRepository _repo;
        private StreamingContent _matrix;

        //TestInitialize added later
        [TestInitialize]
        public void Arrange()
        {
            _matrix = new StreamingContent("Matrix", "Mind bending scifi", 1.75, 8.7, "SciFi", MaturityRating.PG13);
            StreamingContent jurasicPark = new StreamingContent("Jurasic Park", "Dinosaur", 125, 89.4, "Action", MaturityRating.PG13);

            _repo = new StreamingContentRepository();

            _repo.AddContentToDirectory(_matrix);
            _repo.AddContentToDirectory(jurasicPark);
        }


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

        [TestMethod]
        public void GetContentByTitle_ShouldReturnCorrectContent()
        {
            //Arrang
            //Handled in Arrange Method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Matrix");

            //Assert
            Assert.AreEqual(_matrix.Description, searchResult.Description);

        }

        [TestMethod]
        public void DeleteContentByTitle_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent contentToDelete = _repo.GetContentByTitle("Jurasic Park");

            //Act
            bool removeResult = _repo.DeleteContent(contentToDelete);

            //Assert
            Assert.IsTrue(removeResult);
        }

        [TestMethod]
        public void UpdateContent_ShouldReturnTrue()
        {
            StreamingContent contentToUpdate = _repo.GetContentByTitle("Matrix");
            StreamingContent newContent = new StreamingContent("The Matrix", "Scifi", 1.85, 8.95, "Scifi", MaturityRating.PG13);

            //Act
            bool updateResult = _repo.UpdateExistingContent(contentToUpdate, newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }
    }
}
