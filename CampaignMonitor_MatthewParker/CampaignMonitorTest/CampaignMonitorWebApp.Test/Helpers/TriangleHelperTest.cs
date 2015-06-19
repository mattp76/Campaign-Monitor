using System;
using System.Collections.Generic;
using CampaignMonitorWebApp.Helpers;
using CampaignMonitorWebApp.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CampaignMonitorWebApp.Test.Helpers
{
    [TestClass]
    public class TriangleHelperTests
    {

        //A reference was made to this article for the usage of the ExpectedException attribute
        ///http://stackoverflow.com/questions/25893591/c-sharp-unittest-expectedexception
        [TestMethod]
        public void Test_GetTriangleTypeValid()
        {
           
            Assert.AreEqual(string.Format("{0} with output 6", TriangleHelper.TriangleType.Scalene),
                            TriangleHelper.GetTriangleType(3, 4, 5));

        }

        //This test case is failing because of the thrown exception when we have a negative int. The exception will be inside the IntHelper.
        [TestMethod()]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void Test_GetTriangleTypeInValid()
        {
            try
            {
                TriangleHelper.GetTriangleType(3, 4, -5);
              }
            catch (InvalidTriangleException e)
            {
                Assert.AreEqual("Negative numbers invalid triangle exception", e.Message);
                throw;
            }
        }

    }
}