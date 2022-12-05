using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FixWrongResultLibrary;

namespace FixWrongResultLibTests
{
    [TestClass]
    public class FixWrongResultClassTest
    {
        /// <summary>
        /// вводим 20/10, получаем 10/10
        /// </summary>
        [TestMethod]
        public void FixWrongResult__20_10__10_10()
        {

            //Arrange
            string text = "20/10";
            string exp = "10/10";
            //Act
            FixWrongResultClass obj = new FixWrongResultClass();
            string actual = obj.FixWrongResult(text);
            //Assert
            Assert.AreEqual(actual, exp);
        }
        /// <summary>
        /// вводим -20/10, получаем -20/10
        /// </summary>
        [TestMethod]
        public void FixWrongResult__otr20_10__otr20_10()
        {

            //Arrange
            string text = "-20/10";
            string exp = "-20/10";
            //Act
            FixWrongResultClass obj = new FixWrongResultClass();
            string actual = obj.FixWrongResult(text);
            //Assert
            Assert.AreEqual(actual, exp);
        }
        /// <summary>
        /// вводим пустую строку, получаем ошибку
        /// </summary>
        [TestMethod]
        public void FixWrongResult__EmptyString__Exception()
        {

            //Arrange
            string text = "";
            //Act
            FixWrongResultClass obj = new FixWrongResultClass();
            Action actual = () => obj.FixWrongResult(text);

            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        /// <summary>
        /// вводим 35/10/10/25, получаем ошибку
        /// </summary>
        [TestMethod]
        public void FixWrongResult__lotsofnumbers__Exception()
        {

            //Arrange
            string text = "35/10/10/25";
            //Act
            FixWrongResultClass obj = new FixWrongResultClass();
            Action actual = () => obj.FixWrongResult(text);

            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// вводим 35101025, получаем ошибку
        /// </summary>
        [TestMethod]
        public void FixWrongResult__justnumbers__Exception()
        {

            //Arrange
            string text = "35101025";
            //Act
            FixWrongResultClass obj = new FixWrongResultClass();
            Action actual = () => obj.FixWrongResult(text);

            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// вводим "10/1aboba, получаем ошибку
        /// </summary>
        [TestMethod]
        public void FixWrongResult__WithLetters__Exception()
        {

            //Arrange
            string text = "10/1aboba";
            //Act
            FixWrongResultClass obj = new FixWrongResultClass();
            Action actual = () => obj.FixWrongResult(text);

            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
    }
}
