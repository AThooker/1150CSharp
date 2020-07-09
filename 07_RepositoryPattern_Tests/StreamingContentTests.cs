using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Horror)]
        [DataRow(GenreType.Action)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            //Act
            content.TypeOfGenre = typeOfGenre;
            //Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }


    }
}
