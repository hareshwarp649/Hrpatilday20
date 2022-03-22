using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestUserRegistration;
namespace MsTestUserRegistraA
{
    [TestClass]
    public class UnitTestUserRegi
    {
        [TestMethod]
        public void TestMethod1()
        {
            string excepted = "true";
            var actual = UserRegistration.FirstName("Saurav");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestFirstName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegistration.FirstName("Sa");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegistration.FirstName("saurav");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestLastName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegistration.LastName("Kumar");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestLastName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegistration.LastName("Ka");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegistration.LastName("kumar");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegistration.MobileNumber("91 7067845485");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegistration.MobileNumber("7067845485");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegistration.MobileNumber("23 7067845485");
            Assert.AreEqual(excepted, actual1);
            var actual2 = UserRegistration.MobileNumber("91 70678454858");
            Assert.AreEqual(excepted, actual2);
        }
        [TestMethod]
        public void TestPassword_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegistration.Password("SauGav76@#$");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestPassword_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegistration.Password("S9a@#$j");
            Assert.AreEqual(excepted, actual);
        }
    }
    
}