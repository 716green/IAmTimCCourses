using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

// Unit testing with Xunit

// Arrange, Act, Assert
// expected and actual

namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact] // Test Morning
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange - Instantiate instance of the class
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good morning Bob";

            // Act 
            string actual = messages.Greeting("Bob", 6);

            // Assert - This SHOULD have happened
            Assert.Equal(expected, actual);
        }

        [Fact] // Test Afternoon
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange - Instantiate instance of the class
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Bob";

            // Act 
            string actual = messages.Greeting("Bob", 14);

            // Assert - This SHOULD have happened
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Bob", 0, "Good evening Bob")]
        [InlineData("Bob", 1, "Go to bed Bob")]
        [InlineData("Bob", 2, "Go to bed Bob")]
        [InlineData("Bob", 3, "Go to bed Bob")]
        [InlineData("Bob", 4, "Go to bed Bob")]
        [InlineData("Bob", 5, "Good morning Bob")]
        [InlineData("Bob", 6, "Good morning Bob")]
        [InlineData("Bob", 7, "Good morning Bob")]
        [InlineData("Bob", 8, "Good morning Bob")]
        [InlineData("Bob", 9, "Good morning Bob")]
        [InlineData("Bob", 10, "Good morning Bob")]
        [InlineData("Bob", 11, "Good morning Bob")]
        [InlineData("Bob", 12, "Good afternoon Bob")]
        [InlineData("Bob", 13, "Good afternoon Bob")]
        [InlineData("Bob", 14, "Good afternoon Bob")]
        [InlineData("Bob", 15, "Good afternoon Bob")]
        [InlineData("Bob", 16, "Good afternoon Bob")]
        [InlineData("Bob", 17, "Good afternoon Bob")]
        [InlineData("Bob", 18, "Good evening Bob")]
        [InlineData("Bob", 19, "Good evening Bob")]
        [InlineData("Bob", 20, "Good evening Bob")]
        [InlineData("Bob", 21, "Good evening Bob")]
        [InlineData("Bob", 22, "Good evening Bob")]
        [InlineData("Bob", 23, "Good evening Bob")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            //Arrange - Instantiate instance of the class
            DisplayMessages messages = new DisplayMessages();

            // Act 
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert - This SHOULD have happened
            Assert.Equal(expected, actual);
        }
    }
}
