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
    }
}