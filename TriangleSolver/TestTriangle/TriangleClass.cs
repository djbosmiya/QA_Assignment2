using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;


namespace TestTriangle
{
    public class TriangleClass
    {
        //Test Case-1 for Equilateral Triangle
        [Test]
        public void Equilateral_input50and50and50()
        {
            //Arrange
            int firstSide = 50;
            int secondSide = 50;
            int thirdSide = 50;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-2 for Isosceles Triangle
        [Test]
        public void Isosceles_input50and20and50()
        {
            // Arrange
            int firstSide = 50;
            int secondSide = 20;
            int thirdSide = 50;

            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-3 for Isosceles Triangle
        [Test]
        public void Isosceles_input20and50and50()
        {
            // Arrange
            int firstSide = 20;
            int secondSide = 50;
            int thirdSide = 50;

            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-4 for Isosceles Triangle
        [Test]
        public void Isosceles_input50and50and20()
        {
            // Arrange
            int firstSide = 50;
            int secondSide = 50;
            int thirdSide = 20;

            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-5 for Scalene Triangle
        [Test]
        public void Scalene_input3and4and5()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-6 for Scalene Triangle
        [Test]
        public void Scalene_input7and6and4()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 6;
            int thirdSide = 4;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-7 for Scalene Triangle
        [Test]
        public void Scalene_input1and2and3()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 3;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-8 for Scalene Triangle
        [Test]
        public void Scalene_input7and1and4()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 1;
            int thirdSide = 4;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-9 for Scalene Triangle
        [Test]
        public void Scalene_input9and11and13()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 11;
            int thirdSide = 13;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}