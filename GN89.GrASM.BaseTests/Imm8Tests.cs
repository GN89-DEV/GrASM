using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GN89.GrASM.Base;

namespace GN89.GrASM.BaseTests
{
    [TestClass]
    public class Imm8Tests
    {
        [TestMethod]
        public void StingIsIt_123_trueReturrned()
        {
            string testString = "123";
            bool expected = true;
            bool actual = Imm8.StringIsIt(testString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringIsIt_255_falseReturned()
        {
            Assert.AreEqual(false, Imm8.StringIsIt("255"));
        }
    }
}
