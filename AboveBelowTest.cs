using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RTS_Code_Assessment;
using System.Collections.Generic;

namespace AssessmentTests
{
    [TestClass]
    public class AboveBelowTest
    {
        [TestMethod]
        public void ProvidedExample_Test()
        {
            int[] testList = new int[] { 1, 5, 2, 1, 10 };
            int target = 6;
            Dictionary<string, int> test = Assessment.aboveBelow(testList, target);

            Assert.AreEqual(1, test["Above"]);
            Assert.AreEqual(4, test["Below"]);
        }

        [TestMethod]
        public void EmptyList_Test()
        {
            int[] testList = new int[] { };
            int target = 5;
            Dictionary<string, int> test = Assessment.aboveBelow(testList, target);

            Assert.AreEqual(0, test["Above"]);
            Assert.AreEqual(0, test["Below"]);
        }

        [TestMethod]
        public void ZeroTarget_Test()
        {
            int[] testList = new int[] { 3, 5, -3, 4, -5, 6, 8, 3, 4, 5, -3, -4, -2, 4, 10, 10000, -3 };
            int target = 0;
            Dictionary<string, int> test = Assessment.aboveBelow(testList, target);

            Assert.AreEqual(11, test["Above"]);
            Assert.AreEqual(6, test["Below"]);
        }

        [TestMethod]
        public void ContainingTarget_Test()
        {
            int[] testList = new int[] { 3, 5, -3, 4, -5, 6, 8, 3, 4, 5, -3, -4, -2, 4, 10, 10000, -3 };
            int target = -3;
            Dictionary<string, int> test = Assessment.aboveBelow(testList, target);

            Assert.AreEqual(12, test["Above"]);
            Assert.AreEqual(2, test["Below"]);
        }

        [TestMethod]
        public void LargeSmallNumbers_Test()
        {
            int[] testList = new int[] { 3, 5, -3, 4, -5, 6, 8, 3, 4, 5, -3, -4, -2, 4, 10, 10000, -3, 234234523, -13030304, 234, 53452, 12, 346, 765, -3, -52, 200, 5056, 234, 59293, 234, 3, 3, 4, 5, 6, 2, 6, 2, 6, 3, 6, 8, 8, 4, 2, 6 };
            int target = 555555;
            Dictionary<string, int> test = Assessment.aboveBelow(testList, target);

            Assert.AreEqual(1, test["Above"]);
            Assert.AreEqual(46, test["Below"]);
        }
    }
}
