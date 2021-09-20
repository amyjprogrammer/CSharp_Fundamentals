using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        //Arrange
        //Act
        //Assert
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //Arrane
            StreamingContent content = new StreamingContent();

            //Act
            content.Title = "Little Shop of Horrors";

            //Assert
            string expected = "Little Shop of Horrors";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SetDescription_ShouldSetCorrectString()
        {
            var description = new StreamingContent();
            description.Description = "Fun Movie";

            string expected = "Fun Movie";
            string actual = description.Description;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetRunTime_ShouldReturnCorrectRuntTime()
        {
            var runTime = new StreamingContent();
            runTime.RunTime = 120.12;

            double expected = 120.12;
            double actual = runTime.RunTime;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SetGenre_ShouldReturnCorrectGenre()
        {
            var genre = new StreamingContent();
            genre.Genre = "Fantasy";

            string expected = "Fantasy";
            string actual = genre.Genre;

            Assert.AreEqual(expected, actual);
        }

        //testing multiple data points
        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG13, false)]
        [DataRow(MaturityRating.R, false)]
        
        public void SetMaturityRating_ShouldGetCorrectRating(MaturityRating maturity, bool isFamilyFriendly)
        {
            //AAA
            //Arrange
            //Using loaded constructor
            StreamingContent content = new StreamingContent("Title", "Description", .5, 99, "Animation",  maturity);

            //Act
            MaturityRating actualMaturity = content.RatingMaturity;
            MaturityRating expectedMaturity = maturity;

            bool actualIsFamilyFriendly = content.IsFamilyFriendly;
            bool expectedIsFamilyFriendly = isFamilyFriendly;

            //Assert
            Assert.AreEqual(expectedMaturity, actualMaturity);
            Assert.AreEqual(expectedIsFamilyFriendly, actualIsFamilyFriendly);
        }
    }
}
