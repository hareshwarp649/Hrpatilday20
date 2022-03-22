using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mtest1;
namespace MstestFirst
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Sad Message")]
        public void TestMethod1()
        {
            //Arrange
            string message = "I am in sad Mood";
            string expected = "SAD";
            AnalyseMoodfirst moodAnalyzer = new AnalyseMoodfirst(message);

            //Act
            string actual = moodAnalyzer.AnalysingMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy Message")]
        public void TestHappyMoodInMessage()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "HAPPY";
             AnalyseMoodfirst moodAnalyzer = new AnalyseMoodfirst(message);

            //Act
            string actual = moodAnalyzer.AnalysingMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}