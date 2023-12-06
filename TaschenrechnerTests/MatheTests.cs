using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Tests
{
    [TestClass()]
    public class MatheTests
    {
        [TestMethod()]
        public void SummeTest_simple()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = 44;
            int expected = 99;
            //Act
            int actual = Mathe.Summe(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SummeTest_special()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = -44;
            int expected = 11;
            //Act
            int actual = Mathe.Summe(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SubtraktionTest_simple()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = 44;
            int expected = 11;
            //Act
            int actual = Mathe.Subtraktion(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SubtraktionTest_special()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = -44;
            int expected = 99;
            //Act
            int actual = Mathe.Subtraktion(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplikationTest_simple()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = 4;
            int expected = 220;
            //Act
            int actual = Mathe.Multiplikation(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MultiplikationTest_special()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = -4;
            int expected = -220;
            //Act
            int actual = Mathe.Multiplikation(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivisionTest_simple()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = 5;
            int expected = 11;
            //Act
            int actual = Mathe.Division(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivisionTest_special()
        {
            //Arrange
            int ersteZahl = 55;
            int zweiteZahl = -5;
            int expected = -11;
            //Act
            int actual = Mathe.Division(ersteZahl, zweiteZahl);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivisionTest_byZero() 
        {
            int zahl1 = 10;
            int zahl2 = 0;
            //Act &Assert
            Assert.ThrowsException<DivideByZeroException>

            //Assert.ThrowsException<ArgumentException>
                (
                    () => 
                    {
                        Mathe.Division(zahl1, zahl2);
                    }
                );

        }
    }
}