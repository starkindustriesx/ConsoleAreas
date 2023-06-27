using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAreas;
using FiguresAreasLibrary;
using System;

namespace Tests
{
    [TestClass]
    public class AreaTests
    {
        [DataTestMethod]
        [DataRow(-1, 1, 1)]
        [DataRow(3, 3, -1)]
        [DataRow(0, 2, 1)]
        public void Triangle_WhenSidesAreIncorrect_ShouldThrowArgumentOutOfRangeException(double sideA, double sideB, double sideC)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(6, 3, 2)]
        [DataRow(25, 2, 1)]
        public void Triangle_WhenTriangleDoesntExist_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Circle_WhenRadiusIsSmall_ShouldThrowArgumentOutOfRangeException()
        {
            double radius = 1e-4;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 0.433)]
        [DataRow(0.5, 1, 0.8, 0.198)]
        public void Triangle_AreaCalculation(double sideA, double sideB, double sideC, double expectedResult)
        {
            
            var triangle = new Triangle(sideA, sideB, sideC);
            double result = triangle.CalculateArea();

            Assert.AreEqual(expectedResult, result, $"Failed calculation for triangle with sides {sideA}, {sideB}, {sideC}.");
        }

        [DataTestMethod]
        [DataRow(4, 50.265)]
        [DataRow(0.5, 0.785)]
        public void Circle_AreaCalculation(double radius, double expectedResult)
        {

            var circle = new Circle(radius);
            double result = circle.CalculateArea();

            Assert.AreEqual(expectedResult, result, $"Failed calculation for triangle with radius {radius}.");
        }
    }
}
