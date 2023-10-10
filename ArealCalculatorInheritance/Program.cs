namespace ArealCalculatorInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 5);
            var shapeCalculator = new ShapeCalculator();

            Console.WriteLine($"Rectangle with {rectangle.Width}x{rectangle.Height} dimenssions.");
            Console.WriteLine($"Rectangle area: {shapeCalculator.GetArea(rectangle)}cm²");
            Console.WriteLine($"Rectangle perimeter: {shapeCalculator.GetPerimeter(rectangle)}cm");
        }
    }
}