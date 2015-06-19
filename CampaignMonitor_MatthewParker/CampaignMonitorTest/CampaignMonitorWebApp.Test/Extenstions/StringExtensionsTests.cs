using CampaignMonitorWebApp.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CampaignMonitorWebApp.Test.Extenstions
{
    [TestClass]
    public class StringExtensionsTests
    {
        string _testForNull;
        string _testForStringA;
        string _testForEmptyString;
        string _testForEmptyNullString;

        [TestInitialize]
        public void Init()
        {
            //Init variables for the isNullOrEmpty Extension test
            _testForNull = null;
            _testForStringA = "a";
            _testForEmptyString = "";
            _testForEmptyNullString = "null";
        }
        
        [TestMethod]
        public void Test_IsNullOrEmpty()
        {
            Assert.IsTrue(_testForNull.IsNullOrEmpty());
            Assert.IsFalse(_testForStringA.IsNullOrEmpty());
            Assert.IsTrue(_testForEmptyString.IsNullOrEmpty());
            Assert.IsFalse(_testForEmptyNullString.IsNullOrEmpty());
        }
    }
}
