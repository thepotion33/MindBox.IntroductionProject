using MindBox.FiguresLibrary.Models.Exceptions;
using MindBox.FiguresLibrary.Models.Figures;

namespace MindBox.XUnitTests.FiguresLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Test_Triangle_Initialization_With_Negative_Sides()
        {
            Exception actualException = Assert.Throws<MathException>(() => new Triangle(-1, -2, -3));
            Assert.Equal("Triangle side can't equal or less than zero", actualException.Message);
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
            Assert.Equal(17.98d, Figure.GetArea(triangle1));
        }
    }
}
