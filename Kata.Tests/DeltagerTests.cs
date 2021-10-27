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

            // Act
            sut.City = positiveResult;

            // Assert
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

    }
}