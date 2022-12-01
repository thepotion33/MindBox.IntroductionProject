namespace MindBox.FiguresLibrary.Models.Figures
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }
        protected override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        protected override double Perimeter => Math.Round(Math.PI * 2 * Radius, 2);
    }
}
