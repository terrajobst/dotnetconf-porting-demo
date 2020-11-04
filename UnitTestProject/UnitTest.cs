using System;

using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var actual = NorthwindDb.GetData();
            var expected = @"Nancy Davolio: 12/7/2013 3:00:00 PM
Andrew Fuller: 2/18/2017 3:00:00 PM
Margaret Peacock: 9/18/2002 3:00:00 PM
Steven Buchanan: 3/3/2020 3:00:00 PM
";

            Assert.AreEqual(expected, actual);
        }
    }
}
