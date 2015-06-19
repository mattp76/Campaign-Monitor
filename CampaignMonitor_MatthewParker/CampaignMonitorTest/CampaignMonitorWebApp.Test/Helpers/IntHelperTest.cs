using System;
using System.Collections.Generic;
using CampaignMonitorWebApp.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CampaignMonitorWebApp.Test.Helpers
{
    [TestClass]
    public class StringExtensionsTests
    {

        List<int> _divisor60Expected = new List<int>();
        List<int> _divisor42Expected = new List<int>();

        int[] _commonIntegersExpected1;
        int[] _commonIntegersExpected2;
        int[] _commonIntegersExpected3;

        [TestInitialize]
        public void Init()
        {
            //Initialise our 60 divisor list of ints
            _divisor60Expected.Add(1);
            _divisor60Expected.Add(2);
            _divisor60Expected.Add(3);
            _divisor60Expected.Add(4);
            _divisor60Expected.Add(5);
            _divisor60Expected.Add(6);
            _divisor60Expected.Add(10);
            _divisor60Expected.Add(12);
            _divisor60Expected.Add(15);
            _divisor60Expected.Add(20);
            _divisor60Expected.Add(30);
            _divisor60Expected.Add(60);

            //Initialise our 42 divisor list of ints
            _divisor42Expected.Add(1);
            _divisor42Expected.Add(2);
            _divisor42Expected.Add(3);
            _divisor42Expected.Add(6);
            _divisor42Expected.Add(7);
            _divisor42Expected.Add(14);
            _divisor42Expected.Add(21);
            _divisor42Expected.Add(42);

            _commonIntegersExpected1 = new int[] {5, 4};
            _commonIntegersExpected2 = new int[] {1};
            _commonIntegersExpected3 = new int[] {1, 2, 3, 4, 5, 6, 7};
        }

        [TestMethod]
        public void Test_GetDivisors()
        {
            CollectionAssert.AreEqual(_divisor60Expected, IntHelper.GetDivisors(60));
            CollectionAssert.AreEqual(_divisor42Expected, IntHelper.GetDivisors(42));
        }

        [TestMethod]
        public void Test_GetMostPopularElement()
        {
            CollectionAssert.AreEqual(_commonIntegersExpected1, IntHelper.getMostPopularElement(new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }));
            CollectionAssert.AreEqual(_commonIntegersExpected2, IntHelper.getMostPopularElement(new int[] { 1, 2, 3, 4, 5, 1, 6, 7 }));
            CollectionAssert.AreEqual(_commonIntegersExpected3, IntHelper.getMostPopularElement(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
        }


    }
}
