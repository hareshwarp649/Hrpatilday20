using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTest4;
namespace MsUnitTest4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        [TestCategory ("Sad Message")]
        public void TestMethod1()
        {

            string expected = "SAD";
            string message = " I am in Sad Mood";
            MstestFirst moodAnalyze = new MstestFirst(message);

            //Act
            string mood = moodAnalyze.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }
        /// <summary>
        /// TC 1.2 & 2.1 Return happy moood 
        /// </summary>
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void ReturnHappy(string message)
        {
            //Arrange

            string expected = "HAPPY";
          MstestFirst   moodAnalyze = new MstestFirst(message);

            //Act
            string mood = moodAnalyze.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        ///  TC 3.1: Given NULL Mood Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void NULL_MOOD_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MstestFirst moodAnalyze = new MstestFirst(message);
                string mood = moodAnalyze.AnalyseMood();
            }
            catch (MoodTestAnaly e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        /// <summary>
        /// TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                 moodAnalyze = new MoodAnalyze(message);
                string mood = moodAnalyze.AnalyzeMood();
            }
            catch (MoodAnalyzeException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        /// <summary>
        ///  Test Case 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyze();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerApp.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

        /// <summary>
        ///  Test Case 4.2 Given Improper Class Name Should throw MoodAnalyssiException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerApp.DemoClass", "DemoClass");

            }
            catch (MoodAnalyzeException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


        /// <summary>
        /// Test Case 4.3 Given Improper Constructor should throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorShouldThrowMoodAnalysisException()
        {

            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse");
            }
            catch (MoodAnalyzeException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
    
}