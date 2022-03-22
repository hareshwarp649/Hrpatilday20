using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mtest3;
    
namespace MsUnitTest3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        [TestCategory("Sad Message")]
        public void TestMethod1()
        {
            string message = "I am in sad Mood";
            string expected = "SAD";
            CustomExcepFirst moodAnalyzer = new CustomExcepFirst(message);

            //Act
            string actual = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //TC 1.2 - Method to test Happy Mood
        [TestMethod]
        [TestCategory("Happy Message")]
        public void TestHappyMoodInMessage()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "HAPPY";
            CustomExcepFirst moodAnalyser = new CustomExcepFirst(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //TC 2.1 - Method to test Happy Mood in null message
        [TestMethod]
        [TestCategory("Exception")]
        public void GivenNullMessageReturnHappyMood()
        {
            //Arrange
            string? message = null;
            string expected = "HAPPY";
             CustomExcepFirst moodAnalyser= new CustomExcepFirst(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //TC 3.1 - Method to test Custom exception for null message
        [TestMethod]
        [TestCategory("Custom Exception")]
        [DataRow(null, "Message should not be null")]
        [DataRow("", "Message should not be empty")]
        public void GivenNullMessageTestCustomException(string userInput, string expected)
        {
            //Arrange
            //string message = null;
            //string expected = "HAPPY";
            CustomExcepFirst moodAnalyzer = new CustomExcepFirst(userInput);
            try
            {
                //Act
                string actual = moodAnalyzer.AnalyseMood();
            }
            catch (CustomExceptionSec ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
    
}