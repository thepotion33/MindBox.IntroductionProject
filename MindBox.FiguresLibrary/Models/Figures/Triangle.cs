using MindBox.FiguresLibrary.Models.Exceptions;

namespace MindBox.FiguresLibrary.Models.Figures
{
    public class Triangle : Figure
    {
        public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            FirstSideLength = firstSideLength <= 0 ? throw new MathException("Triangle side can't equal or less than zero") : firstSideLength;
            SecondSideLength = secondSideLength <= 0 ? throw new MathException("Triangle side can't equal or less than zero") : secondSideLength;
            ThirdSideLength = thirdSideLength <= 0 ? throw new MathException("Triangle side can't equal or less than zero") : thirdSideLength;

            _sides = new List<double> { firstSideLength, secondSideLength, thirdSideLength };
        }

        public double FirstSideLength { get; }
        public double SecondSideLength { get; }
        public double ThirdSideLength { get; }

        protected override double Area => _sides.Any(x => x >= SemiPerimeter)
            ? throw new MathException("One of the sides of triangle is equal or more than semi perimeter")
            : Math.Round(Math.Sqrt(SemiPerimeter * (SemiPerimeter - FirstSideLength) * (SemiPerimeter - SecondSideLength) * (SemiPerimeter - ThirdSideLength)), 2);

        protected override double Perimeter => FirstSideLength + SecondSideLength + ThirdSideLength;

        private double SemiPerimeter => Perimeter / 2;

        private readonly IList<double> _sides;
    }
}
