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
        public void Scalene_input70and80and100()
        {
            // Arrange
            int firstSide = 70;
            int secondSide = 80;
            int thirdSide = 100;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-8 for Scalene Triangle
        [Test]
        public void Scalene_input25and26and27()
        {
            // Arrange
            int firstSide = 25;
            int secondSide = 26;
            int thirdSide = 27;

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

        //Test Case-10 for  verifying a zero length for one or more sides
        [Test]
        public void SideWithZero_input0and3and4()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 3;
            int thirdSide = 4;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-11 for  verifying a zero length for one or more sides
        [Test]
        public void SideWithZero_input0and0and9()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 9;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-12 for  verifying a zero length for one or more sides
        [Test]
        public void SideWithZero_input25and0and21()
        {
            // Arrange
            int firstSide = 25;
            int secondSide = 0;
            int thirdSide = 21;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-13 for verifying an invalid response (other than a zero length)
        [Test]
        public void InvalidResponse_input1and2and4()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 4;

            string expected = "A triangle cannot be formed with those numbers";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-14 for verifying an invalid response (other than a zero length)
        [Test]
        public void InvalidResponse_input2and2and4()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 4;

            string expected = "A triangle cannot be formed with those numbers";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case-15 for verifying an invalid response (other than a zero length)
        [Test]
        public void InvalidResponse_input9and2and1()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 2;
            int thirdSide = 1;

            string expected = "A triangle cannot be formed with those numbers";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}