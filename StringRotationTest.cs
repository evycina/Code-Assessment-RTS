using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RTS_Code_Assessment;
using System.Collections.Generic;

namespace AssessmentTests
{
    [TestClass]
    public class StringRotationTest
    {
        [TestMethod]
        public void ProvidedExample_Test()
        {
            string input = "MyString";
            int rotation = 2;
            string test = Assessment.stringRotation(input, rotation);

            Assert.AreEqual("ngMyStri", test);
        }

        [TestMethod]
        public void LargeRotation_Test()
        {
            string input = "MyString";
            int rotation = 46;
            string test = Assessment.stringRotation(input, rotation);

            Assert.AreEqual("StringMy", test);
        }

        [TestMethod]
        public void EmptyString_Test()
        {
            string input = "";
            int rotation = 14;
            string test = Assessment.stringRotation(input, rotation);

            Assert.AreEqual("", test);
        }

        [TestMethod]
        public void NullString_Test()
        {
            string input = null;
            int rotation = 14;
            string test = Assessment.stringRotation(input, rotation);

            Assert.AreEqual("", test);
        }

        [TestMethod]
        public void OneLetterString_Test()
        {
            string input = "a";
            int rotation = 30;
            string test = Assessment.stringRotation(input, rotation);

            Assert.AreEqual("a", test);
        }

        [TestMethod]
        public void StringWithSpacesAndSpecialCharacters_Test()
        {
            string input = "a   wdfwef  23423 $$$%%%%%  2#@#$@#$@ # 4 4 444     #";
            int rotation = 30;
            string test = Assessment.stringRotation(input, rotation);

            Assert.AreEqual("%%%  2#@#$@#$@ # 4 4 444     #a   wdfwef  23423 $$$%%", test);
        }
    }
}
