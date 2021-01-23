using System;
using CalculateAreaLibrary.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateAreaLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateCircleAreaWithCorrectArgument()
        {
            //Arrange
            const double radius = 3;
            const double expectedArea = Math.PI * radius * radius;

            var circle = new Circle(radius);

            //Act
            var actualArea = circle.CalculateArea();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Радиус круга должен быть больше нуля!!!")]
        public void CalculateCircleAreaWithInCorrectArgument()
        {
            //Arrange
            const double radius = -3;
            const double expectedArea = Math.PI * radius * radius;

            var circle = new Circle(radius);

            //Act
            var actualArea = circle.CalculateArea();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculateTriangleAreaWithCorrectArgument()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            var area = triangle.CalculateArea();

            //assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Параметры должны быть больше нуля!!!")]
        public void CalculateTriangleAreaWithInCorrectArgument()
        {
            //Arrange
            Triangle triangle = new Triangle(-3, 4, 5);

            //act
            var area = triangle.CalculateArea();

            //assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsTrue(isRight);
        }
    }
}
