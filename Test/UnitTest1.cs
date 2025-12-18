using System;
using NUnit.Framework;
namespace Test
{
    public class Tests
    {
        [Test]
        public void posTest()
        {
            Assert.IsTrue(ProgramBUFF_TC.CheckTriangle(3, 4, 5, 0));
            Assert.IsTrue(ProgramBUFF_TC.CheckTriangle(3, 4, 5, 1));
            Assert.IsTrue(ProgramBUFF_TC.CheckTriangle(5, 4, 3, 1));
        }
        [Test]
        public void negTest()
        {
            Assert.IsFalse(ProgramBUFF_TC.CheckTriangle(2, 3, 4, 1));
            Assert.IsFalse(ProgramBUFF_TC.CheckTriangle(5, 5, 3, 3));
            Assert.IsFalse(ProgramBUFF_TC.CheckTriangle(0, 4, 5, 0));
        }
    }
}