using MindBox.FiguresLibrary.Models.Figures;

namespace MindBox.XUnitTests.FiguresLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Test_Circle_Area_Calculation()
        {
            var circle = new Circle(3);
            Assert.Equal(28.27, Figure.GetArea(circle));
        }

        [Fact]
        public void Test_Circle_Perimeter_Calculation()
        {
            var circle = new Circle(3);
            Assert.Equal(18.85, Figure.GetPerimeter(circle));
        }
    }
}
