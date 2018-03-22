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
    public class PileOfCubesTests
    {
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(45, PileOfCubes.FindNb(1071225));
        }
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(2022, PileOfCubes.FindNb(4183059834009));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(-1, PileOfCubes.FindNb(24723578342962));
        }
        
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(4824, PileOfCubes.FindNb(135440716410000));
        }
        
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(3568, PileOfCubes.FindNb(40539911473216));
        }
        
        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(1, PileOfCubes.FindNb(1));
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(2, PileOfCubes.FindNb(9));
        }
        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(3, PileOfCubes.FindNb(36));
        }
        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(4, PileOfCubes.FindNb(100));
        }
        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(-1, PileOfCubes.FindNb(121));
        }
    }
}