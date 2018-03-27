using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Tests
{
    [TestClass()]
    public class TimeFormatTests
    {
        [TestMethod()]
        public void GetReadableTimeTest()
        {
            Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
            Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
            Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
            Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
        }
    }
}