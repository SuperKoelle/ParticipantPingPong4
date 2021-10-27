using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class ParticipantsTests
    {
        [Fact]
        [Trait("Category", "City")]
        public void ParticipantsCityNameMustThrowExeptionIfItContainsSpecialCharacters()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#";

            // Act & // Assert
            Assert.Throws<ArgumentException>(() => sut.City = positiveResult);
        }

        [Fact]
        [Trait("Category", "City")]
        public void ParticipantsCitySymbols()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "vejle";

            // Act
            sut.City = positiveResult;

            // Assert
            sut.City.Should().Be(positiveResult);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void NamesShouldNotBeEmpty()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "";
            
            // Act & // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
           
        }
        [Fact]
        [Trait("Category", "Name")]
        public void NamesShouldNotBeNull()
        {
            // Arrange
            var sut = new Participant();
            
            string positiveResult = null;
            // Act & // Assert
           
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void ParticipantsNameMustThrowExeptionIfItContainsSpecialCharacters()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#";

            // Act & // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void ParticipantsNameMustNotThrowExeptionIfItDoesNotContainsSpecialCharacters()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Superkølle";

            sut.Name = positiveResult;

            // Act & // Assert

            Assert.Equal(sut.Name, positiveResult);
        }

        [Theory]
        [InlineData("Anna", "Anna")]
        [InlineData("anna", "Anna")]
        [InlineData("Anna-Marie", "Anna-Marie")]
        [InlineData("anna-marie", "Anna-Marie")]
        [InlineData("Anna Marie", "Anna Marie")]
        [InlineData("anna marie", "Anna Marie")]
        [InlineData("aNna", "Anna")]
        [InlineData("ANNA", "Anna")]
        [Trait("Category", "Name")]
        public void ParticipantsNameMustNotHaveLowerCaseAsSecondLetter(string value, string expected)
        {
            // Arrange
            var sut = new Participant();

            sut.Name = value;
            
            var temp = sut.Name;

            // Act & // Assert
            Assert.Equal(expected, temp);
        }

    }
}