using MindBox.FiguresLibrary.Models.Exceptions;
using MindBox.FiguresLibrary.Models.Figures;

namespace MindBox.XUnitTests.FiguresLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Test_Triangle_Initialization_With_Negative_Sides()
        {
            Exception actualException1 = Assert.Throws<MathException>(() => new Triangle(-1, -2, -3));
            Assert.Equal("Triangle side can't equal or less than zero", actualException1.Message);

            Exception actualException2 = Assert.Throws<MathException>(() => new Triangle(-1, 2, 1));
            Assert.Equal("Triangle side can't equal or less than zero", actualException2.Message);

            Exception actualException3 = Assert.Throws<MathException>(() => new Triangle(-1, -2, 3));
            Assert.Equal("Triangle side can't equal or less than zero", actualException3.Message);
        }

        [Fact]
        public void Test_Triangle_Perimeter_Calculation()
        {
            var triangle1 = new Triangle(1, 2, 3);
            Assert.Equal(6, Figure.GetPerimeter(triangle1));

            var triangle2 = new Triangle(10, 20, 30);
            Assert.Equal(60, Figure.GetPerimeter(triangle2));
        }

        [Fact]
        public void Test_Triangle_Area_Calculation()
        {
            var triangle1 = new Triangle(4, 9, 10);
            Assert.Equal(17.98, Figure.GetArea(triangle1));
        }

        [Fact]
        public void Test_Triangle_Semi_Perimeter_Area_Calculation()
        {
            var triangle = new Triangle(1, 2, 3);
            Exception actualException1 = Assert.Throws<MathException>(() => Figure.GetArea(triangle));
            Assert.Equal("One of the sides of triangle is equal or more than semi perimeter", actualException1.Message);
        }
    }
}
