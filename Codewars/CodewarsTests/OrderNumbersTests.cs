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
    public class OrderNumbersTests
    {
        [TestMethod()]
        public void OrderNumbersTest()
        {
            Assert.AreEqual(0, OrderNumbers.DescendingOrder(0));
            Assert.AreEqual(654321, OrderNumbers.DescendingOrder(352461));
        }
    }
}