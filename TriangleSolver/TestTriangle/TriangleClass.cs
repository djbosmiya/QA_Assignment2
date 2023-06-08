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
    }
}