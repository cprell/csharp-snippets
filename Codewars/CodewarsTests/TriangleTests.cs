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
    public class TriangleTests
    {
        [TestMethod()]
        public void IsTriangleTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
            Assert.IsFalse(Triangle.IsTriangle(10, 2, 13));
        }
    }
}