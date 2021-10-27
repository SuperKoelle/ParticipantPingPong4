using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class ParticipantsTests
    {
        [Fact]
        public void ParticipantsCityNameMustThrowExeptionIfItContainsSpecialCharacters()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#";

            // Act & // Assert
            Assert.Throws<ArgumentException>(() => sut.City = positiveResult);
        }

        [Fact]
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
        public void NamesShouldNotBeEmpty()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "";
            
            // Act & // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
           
        }
        [Fact]
        public void NamesShouldNotBeNull()
        {
            // Arrange
            var sut = new Participant();
            
            string positiveResult = null;
            // Act & // Assert
           
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }

        [Fact]
        public void ParticipantsNameMustThrowExeptionIfItContainsSpecialCharacters()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#";

            // Act & // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }

        [Fact]
        public void ParticipantsNameMustNotThrowExeptionIfItDoesNotContainsSpecialCharacters()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Superkølle";

            sut.Name = positiveResult;

            // Act & // Assert

            Assert.Equal(sut.Name, positiveResult);
        }

    }
}