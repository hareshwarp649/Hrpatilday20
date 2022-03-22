using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest5;
namespace MsUnitTest5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "SAD";
            string message = " I am in Sad Mood";
            MoodAnalyFir moodAnalyze = new MoodAnalyFir(message);

            //Act
            string mood = moodAnalyze.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }
      
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void ReturnHappy(string message)
        {
            //Arrange

            string expected = "HAPPY";
            MoodAnalyFir moodAnalyze = new MoodAnalyFir(message);

            //Act
            string mood = moodAnalyze.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
       
        [TestMethod]
        public void NullMoodAnalyException()
        {
            try
            {
                string? message = null;
                MoodAnalyFir moodAnalyze = new MoodAnalyFir(message);
                string mood = moodAnalyze.AnalyseMood();
            }
            catch (MoodAnalExcep e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
       
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyFir moodAnalyze = new MoodAnalyFir(message);
                string mood = moodAnalyze.AnalyseMood();
            }
            catch (MoodAnalExcep e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
      
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyFir();
            object obj = MaFactory.CreateMoodAnalyse("MoodAnalyzerApp.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MaFactory.CreateMoodAnalyse("MoodAnalyzerApp.DemoClass", "DemoClass");

            }
            catch (MoodAnalExcep exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


        [TestMethod]
        public void GivenImproperConstructorShouldThrowMoodAnalysisException()
        {

            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MaFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse");
            }
            catch (MoodAnalExcep exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
     
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyFir("HAPPY");
            object obj = MaFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

       
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MaFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.DemoClass", "MoodAnalyse");

            }
            catch (MoodAnalExcep exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
       
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MaFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse", "DemoConstructor");

            }
            catch (MoodAnalExcep exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
    
}