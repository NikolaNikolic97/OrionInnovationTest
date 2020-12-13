using FluentAssertions;
using Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TextTests
{
    public class UserInputTests
    {
        [Fact]
        public void TestRead_WithEmptyString()
        {
            var userInputImplementation = new ReadTextUserInput();
            userInputImplementation.Invoking(x => x.Read(""))
                .Should().Throw<Exception>()
                .WithMessage("There is no text sent.");
        }

        [Fact]
        public void TestRead_WithStringStarting_WithWhiteSpace()
        {
            var userInputImplementation = new ReadTextUserInput();
            userInputImplementation.Read("   test test test")
                .Should().Be(3);
        }

        [Fact]
        public void TestRead_WithStringEnding_WithWhiteSpace()
        {
            var userInputImplementation = new ReadTextUserInput();
            userInputImplementation.Read("test test    test    ")
                .Should().Be(3);
        }
    }
}
