namespace MindBox.FiguresLibrary.Models.Figures
{
    public abstract class Figure
    {
        protected abstract double Area { get; }
        protected abstract double Perimeter { get; }

        public static double GetArea(Figure figure) => figure.Area;
        public static double GetPerimeter(Figure figure) => figure.Perimeter;
    }
}
